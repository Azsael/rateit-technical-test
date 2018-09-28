using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RateIt.Core.Companies;
using RateIt.Core.Companies.Models;

namespace RateIt.TechnicalTest.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
	    private readonly ICompanyService _companyService;

	    public CompaniesController(ICompanyService companyService)
	    {
		    _companyService = companyService;
	    }

		[HttpGet]
	    public Task<IList<CompanyVM>> GetCompanies()
	    {
		    return _companyService.GetCompanies();
	    }
	}
}
