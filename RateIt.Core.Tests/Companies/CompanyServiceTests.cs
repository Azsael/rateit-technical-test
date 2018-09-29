using System.Threading.Tasks;
using FluentAssertions;
using RateIt.Core.Companies;
using RateIt.Entities.Tests;
using Xunit;

namespace RateIt.Core.Tests.Companies
{
    public class CompanyServiceTests
    {
	    private readonly CompanyService _service;

	    public CompanyServiceTests()
		{
			var context = TestEntityFactory.SetupContext();
			var entityFactory = TestEntityFactory.SetupEntityFactory(context);

			_service = new CompanyService(entityFactory);
		}

		[Fact]
        public async Task GivenGetCompanies_WhenGettingCompanies_ThenWeGetTheCompanies()
		{
			var companies = await _service.GetCompanies();

			companies.Should().HaveCountGreaterOrEqualTo(3);
			companies.Should().Contain(x => x.CompanyId == 2 && x.Name == "Redberry" && x.Timezone == "Singapore Standard Time");
		}
    }
}
