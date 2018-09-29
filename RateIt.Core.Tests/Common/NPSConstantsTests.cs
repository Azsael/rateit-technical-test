using FluentAssertions;
using RateIt.Core.Common;
using RateIt.Core.Reporting;
using Xunit;

namespace RateIt.Core.Tests.Common
{
    public class NPSConstantsTests
    {
		[Theory]
        [InlineData(0, NPSRespondentType.Detractor)]
        [InlineData(2, NPSRespondentType.Detractor)]
        [InlineData(4, NPSRespondentType.Detractor)]
        [InlineData(6, NPSRespondentType.Detractor)]
        [InlineData(7, NPSRespondentType.Passive)]
        [InlineData(8, NPSRespondentType.Passive)]
        [InlineData(9, NPSRespondentType.Promoter)]
        [InlineData(10, NPSRespondentType.Promoter)]
        public void GivenGetRespondentType_WhenGivenRating_ThenExpectedTypeReturned(int rating, NPSRespondentType type)
		{
			NPSConstants.GetRespondentType(rating).Should().Be(type);
		}
    }
}
