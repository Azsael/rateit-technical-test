using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RateIt.Core.Companies.Models;

namespace RateIt.Core.Companies
{
    public interface ICompanyService
    {
		Task<IList<CompanyVM>> GetCompanies();
    }
}
