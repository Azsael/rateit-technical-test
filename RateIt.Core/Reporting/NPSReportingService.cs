using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RateIt.Common;
using RateIt.Core.Common;
using RateIt.Core.Reporting.Models;
using RateIt.Entities.Context;
using RateIt.Entities.Models;

namespace RateIt.Core.Reporting
{
	internal class NPSReportingService : INPSReportingService
	{
		private readonly IFactory<IRatingsContext> _entityFactory;

		public NPSReportingService(IFactory<IRatingsContext> entityFactory)
		{
			_entityFactory = entityFactory;
		}

		public async Task<IList<NPSRating>> GetNPSTrends(NPSTrendFilter filter)
		{
			filter = filter ?? new NPSTrendFilter();
			filter.TrendPeriod = filter.TrendPeriod ?? NPSTrendPeriod.Monthly;

			var dbContext = _entityFactory.Create();

			var ratings = await dbContext.RatingResults
				.WhereIf(filter.CompanyIds?.Any() == true, x => filter.CompanyIds.Contains(x.Rating.CompanyId))
				.WhereIf(filter.From.HasValue, x => filter.From <= x.Rating.DateRecorded)
				.WhereIf(filter.To.HasValue, x => filter.To >= x.Rating.DateRecorded)
				.Where(x => x.ResultType == RatingResultType.Nps)
				.Where(x => !string.IsNullOrWhiteSpace(x.Value))
				.Select(x => new { Rating = x.Value, RecordedOn = x.Rating.DateRecorded, CompanyId = x.Rating.CompanyId, Timezone = x.Rating.Company.Timezone })
				.ToListAsync();
			
			return ratings
				.Where(x => int.TryParse(x.Rating, out _))
				.Select(x => new { Rating = int.Parse(x.Rating), RecordedOn = x.RecordedOn, Timezone = x.Timezone })
				.Select(x => new { Type = NPSConstants.GetRespondentType(x.Rating), Rating = x.Rating, RecordedOn = x.RecordedOn, Timezone = x.Timezone })
				.GroupBy(x => GetNPSTrendBucket(x.RecordedOn, x.Timezone, filter.TrendPeriod.Value))
				.Select(x => new NPSRating
				{
					TrendPeriod = filter.TrendPeriod.Value,
					TrendTime = x.Key,
					Score = (int)(x.Sum(y => (int)y.Type) / (decimal)x.Count() * 100) 
				})
				.OrderBy(x => x.TrendTime)
				.ToList();
		}

		/// <summary>
		/// Lets work out what "bucket" the rating falls into. If we add more periods etc we probably want to refactor this out tho.
		/// </summary>
		internal DateTime GetNPSTrendBucket(DateTimeOffset recordedOn, string timezone, NPSTrendPeriod period)
		{
			// I don't know what "format" these timezones are in. But my system doesn't recognise western australia but does the other ones
			// I honestly prefer IANA timezones as they also cater for the yearly changes of DST
			timezone = timezone == "Australian Western Standard Time" ? "W. Australia Standard Time" : timezone;
			var timezoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timezone);

			var dateTime = TimeZoneInfo.ConvertTime(recordedOn, timezoneInfo);

			if (period == NPSTrendPeriod.Daily)
				return dateTime.Date;

			if (period == NPSTrendPeriod.Monthly)
				return new DateTime(dateTime.Year, dateTime.Month, 1);

			// how do you do weekly? is it from start bracket (to/from) or the days of the week or is it from weeks of the year?
			// lets just do this weird formula of week of year as first day, being a sunday or such? ODD!
			var date = dateTime.Date;

			while (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfYear != 1)
			{
				date = date.AddDays(-1);
			}
			return date;
		}
	}
}