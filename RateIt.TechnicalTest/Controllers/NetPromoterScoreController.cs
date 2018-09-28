using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RateIt.Core.Reporting;
using RateIt.Core.Reporting.Models;

namespace RateIt.TechnicalTest.Controllers
{
    [Route("api/NPS")]
    public class NetPromoterScoreController : Controller
    {
		private readonly INPSReportingService _npsReportService;

	    public NetPromoterScoreController(INPSReportingService npsReportService)
	    {
		    _npsReportService = npsReportService;
	    }

		[HttpGet]
		public Task<IList<NPSRating>> GetNPSTrends([FromQuery]NPSTrendFilter filter)
		{
			return _npsReportService.GetNPSTrends(filter);
		}
    }
}
