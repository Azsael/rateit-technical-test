using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RateIt.Core.Reporting.Models;

namespace RateIt.Core.Reporting
{
    public interface INPSReportingService
    {
	    Task<IList<NPSRating>> GetNPSTrends(NPSTrendFilter filter);
    }
}

