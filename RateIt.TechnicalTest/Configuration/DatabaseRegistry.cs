using RateIt.TechnicalTest.Data;

namespace RateIt.TechnicalTest.Configuration
{
    public class DatabaseRegistry : StructureMap.Registry
    {
        public DatabaseRegistry()
        {
            For<IRatingsContext>()
                .Use<RatingsContext>();
        }
    }
}
