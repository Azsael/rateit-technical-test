using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RateIt.Core.Reporting.Models;

namespace RateIt.Core.Reporting
{
	internal class NPSReportingService : INPSReportingService
	{
		public Task<IList<NPSRating>> GetNPSTrends(NPSTrendFilter filter)
		{
			throw new NotImplementedException();
		}
	}
}