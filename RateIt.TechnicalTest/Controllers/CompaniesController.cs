using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RateIt.TechnicalTest.Data.Models;

namespace RateIt.TechnicalTest.Controllers
{
    [Route("api/companies/")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new List<Company>());
        }
    }
}
