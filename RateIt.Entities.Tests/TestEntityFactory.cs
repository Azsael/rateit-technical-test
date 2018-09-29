using System;
using Microsoft.EntityFrameworkCore;
using Moq;
using RateIt.Common;
using RateIt.Entities.Context;

namespace RateIt.Entities.Tests
{
    public static class TestEntityFactory
    {
        public static IFactory<T> SetupEntityFactory<T>(T context)
        {
            var entityFactory = new Mock<IFactory<T>>();
            entityFactory.Setup(x => x.Create()).Returns(context);

            return entityFactory.Object;
        }

        public static IRatingsContext SetupContext()
        {
            //var options = new DbContextOptionsBuilder<RatingsContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var options = new DbContextOptionsBuilder<RatingsContext>().UseSqlite("Data Source=ratings.db").Options;
			var dbContext = new RatingsContext(options);

	        dbContext.Database.EnsureCreated();
			
            return dbContext;
        }
    }
}
