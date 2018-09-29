using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RateIt.Common;
using RateIt.Core.Companies.Models;
using RateIt.Entities.Context;

namespace RateIt.Core.Companies
{
	internal class CompanyService : ICompanyService
	{
		private readonly IFactory<IRatingsContext> _entityFactory;

		public CompanyService(IFactory<IRatingsContext> entityFactory)
		{
			_entityFactory = entityFactory;
		}

		public async Task<IList<CompanyVM>> GetCompanies()
		{
			var dbContext = _entityFactory.Create();

			return await dbContext.Companies
				.Select(x => new CompanyVM
				{
					CompanyId = x.Id,
					Name = x.Name,
					Timezone = x.Timezone
				})
				.ToListAsync();
		}
	}
}