using System;
using RateIt.Entities.Context;
using Microsoft.Extensions.DependencyInjection;

namespace RateIt.Entities.Ioc
{
    public class DatabaseRegistry : StructureMap.Registry
    {
        public DatabaseRegistry()
        {
            For<IRatingsContext>()
                .Use<RatingsContext>();
        }

	    public static void OnConfigure(IServiceProvider serviceProvider)
		{
			serviceProvider.GetService<IRatingsContext>().Database.EnsureCreated();
	    }
    }
}
