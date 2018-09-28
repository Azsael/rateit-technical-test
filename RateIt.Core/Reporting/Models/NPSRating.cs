using System;

namespace RateIt.Core.Reporting.Models
{
	public class NPSRating
	{
		public NPSTrendPeriod TrendPeriod { get; set; }
		public DateTime TrendTime { get; set; }
		public int? Score { get; set; }
	}
}