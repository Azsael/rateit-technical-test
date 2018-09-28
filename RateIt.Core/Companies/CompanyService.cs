using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RateIt.Core.Companies.Models;

namespace RateIt.Core.Companies
{
	internal class CompanyService : ICompanyService
	{
		public Task<IList<CompanyVM>> GetCompanies()
		{
			throw new NotImplementedException();
		}
	}
}