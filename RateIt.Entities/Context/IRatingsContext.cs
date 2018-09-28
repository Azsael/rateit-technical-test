using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RateIt.Entities.Models;

namespace RateIt.Entities.Context
{
	public interface IRatingsContext
	{
		DbSet<Company> Companies { get; set; }
		DbSet<Rating> Ratings { get; set; }
		DbSet<RatingResult> RatingResults { get; set; }

		DatabaseFacade Database { get; }
	}
}
