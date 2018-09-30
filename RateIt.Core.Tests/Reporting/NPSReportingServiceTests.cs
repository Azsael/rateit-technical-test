using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using RateIt.Core.Reporting;
using RateIt.Core.Reporting.Models;
using RateIt.Entities.Tests;
using Xunit;

namespace RateIt.Core.Tests.Reporting
{
    public class NPSReportingServiceTests
	{
		private readonly NPSReportingService _service;

		public NPSReportingServiceTests()
		{
			var context = TestEntityFactory.SetupContext();
			var entityFactory = TestEntityFactory.SetupEntityFactory(context);

			_service = new NPSReportingService(entityFactory);
		}

		[Fact]
        public async Task GivenGetNPSTrends_WhenProvidingNullFilter_ThenRatingsWithMonthlyBucket()
		{
			var ratings = await _service.GetNPSTrends(null);



			ratings.Should().NotBeNullOrEmpty();
			ratings.Should().OnlyContain(x => x.TrendPeriod == NPSTrendPeriod.Monthly);
		}

		[Fact]
        public async Task GivenGetNPSTrends_WhenProvidingPeriodFilter_ThenRatingsInProvidedBucket()
		{
			var filter = new NPSTrendFilter {TrendPeriod = NPSTrendPeriod.Weekly};
			var ratings = await _service.GetNPSTrends(filter);

			ratings.Should().NotBeNullOrEmpty();
			ratings.Should().OnlyContain(x => x.TrendPeriod == NPSTrendPeriod.Weekly);
		}

		[Fact]
        public async Task GivenGetNPSTrends_WhenProvidingFromFilter_ThenRatingsAfterFrom()
		{
			var filter = new NPSTrendFilter { From = new DateTime(2018, 6, 6), TrendPeriod = NPSTrendPeriod.Daily};
			var ratings = await _service.GetNPSTrends(filter);

			ratings.Should().NotBeNullOrEmpty();
			ratings.Should().OnlyContain(x => x.TrendTime >= filter.From.Value );
		}

		[Fact]
        public async Task GivenGetNPSTrends_WhenProvidingToFilter_ThenRatingsBeforeTo()
		{
			var filter = new NPSTrendFilter { To = new DateTime(2018, 6, 6), TrendPeriod = NPSTrendPeriod.Daily };
			var ratings = await _service.GetNPSTrends(filter);

			ratings.Should().NotBeNullOrEmpty();
			ratings.Should().OnlyContain(x => x.TrendTime <= filter.To.Value.Date);
		}
		
		[Fact]
        public async Task GivenGetNPSTrends_WhenProvidingCompanyIdFilter_ThenRatingsForCompany()
		{
			var filter = new NPSTrendFilter { CompanyIds = new [] {1}, TrendPeriod = NPSTrendPeriod.Daily };
			var ratings = await _service.GetNPSTrends(filter);

			ratings.Should().NotBeNullOrEmpty();
		}
		[Fact]
        public async Task GivenGetNPSTrends_WhenProvidingInvalidCompanyIdFilter_ThenNoRatingsBeforeTo()
		{
			var filter = new NPSTrendFilter { CompanyIds = new [] {-1}, TrendPeriod = NPSTrendPeriod.Daily };
			var ratings = await _service.GetNPSTrends(filter);

			ratings.Should().BeNullOrEmpty();
		}

		[Fact]
        public void GivenGetNPSTrendBucket_WhenBucketIsMonthly_ThenResultIsStartOfMonth()
		{
			var result = _service.GetNPSTrendBucket(DateTimeOffset.UtcNow, "UTC", NPSTrendPeriod.Monthly);

			result.Should().Be(new DateTime(DateTimeOffset.UtcNow.Year, DateTimeOffset.UtcNow.Month, 1));
		}

		[Fact]
        public void GivenGetNPSTrendBucket_WhenBucketIsDaily_ThenResultIsStartOfDay()
		{
			var result = _service.GetNPSTrendBucket(DateTimeOffset.UtcNow, "UTC", NPSTrendPeriod.Daily);

			result.Should().Be(DateTimeOffset.UtcNow.Date);
		}

		[Fact]
        public void GivenGetNPSTrendBucket_WhenBucketIsWeekly_ThenResultIsStartOfWeek()
		{
			var result = _service.GetNPSTrendBucket(new DateTimeOffset(new DateTime(2018, 9, 20), TimeSpan.Zero), "UTC", NPSTrendPeriod.Weekly);

			result.Should().Be(new DateTime(2018, 9, 16));

			result = _service.GetNPSTrendBucket(new DateTimeOffset(new DateTime(2018, 1, 1), TimeSpan.Zero), "UTC", NPSTrendPeriod.Weekly);

			result.Should().Be(new DateTime(2018, 1, 1));

			result = _service.GetNPSTrendBucket(new DateTimeOffset(new DateTime(2018, 1, 8), TimeSpan.Zero), "UTC", NPSTrendPeriod.Weekly);

			result.Should().Be(new DateTime(2018, 1, 7));

			result = _service.GetNPSTrendBucket(new DateTimeOffset(new DateTime(2019, 1, 1), TimeSpan.Zero), "UTC", NPSTrendPeriod.Weekly);

			result.Should().Be(new DateTime(2019, 1, 1));
			result = _service.GetNPSTrendBucket(new DateTimeOffset(new DateTime(2019, 1, 6), TimeSpan.Zero), "UTC", NPSTrendPeriod.Weekly);

			result.Should().Be(new DateTime(2019, 1, 6));
			result = _service.GetNPSTrendBucket(new DateTimeOffset(new DateTime(2019, 1, 10), TimeSpan.Zero), "UTC", NPSTrendPeriod.Weekly);

			result.Should().Be(new DateTime(2019, 1, 6));
		}
    }
}
