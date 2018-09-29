using System;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using RateIt.Entities.Context;
using Microsoft.Extensions.DependencyInjection;
[assembly: InternalsVisibleTo("RateIt.Entities.Tests")]

namespace RateIt.Entities.Ioc
{
    public class DatabaseRegistry : StructureMap.Registry
    {
        public DatabaseRegistry()
		{
			// try to replicate AddDbContext 
			var option = new DbContextOptionsBuilder();
			var dbContextOptions = option.UseSqlite("Data Source=ratings.db").Options;

			For<IRatingsContext>().Use(x => new RatingsContext(dbContextOptions));
		}

	    public static void OnConfigure(IServiceProvider serviceProvider)
		{
			serviceProvider.GetService<IRatingsContext>().Database.EnsureCreated();
	    }
    }
}
