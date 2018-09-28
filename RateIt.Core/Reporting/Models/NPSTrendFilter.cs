using System;
using System.Collections.Generic;

namespace RateIt.Core.Reporting.Models
{
	public class NPSTrendFilter
	{
		public DateTime? From { get; set; }
		public DateTime? To { get; set; }

		public IList<int> CompanyIds { get; set; }
		public NPSTrendPeriod? TrendPeriod { get; set; }
	}
}