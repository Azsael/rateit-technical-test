using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RateIt.TechnicalTest.Data.Models;

namespace RateIt.TechnicalTest.Data
{
    public interface IRatingsContext
    {
        DbSet<Company> Companies { get; set; }
        DbSet<Rating> Ratings { get; set; }
        DbSet<RatingResult> RatingResults { get; set; }

        DatabaseFacade Database { get; }
    }

    public class RatingsContext : DbContext, IRatingsContext
    {
        public DbSet<Company> Companies { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<RatingResult> RatingResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ratings.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 1,
                Name = "Blueberry",
                Timezone = "AUS Eastern Standard Time"
            },
                                                   new Company
                                                   {
                                                       Id = 2,
                                                       Name = "Redberry",
                                                       Timezone = "Singapore Standard Time"
                                                   },
                                                   new Company
                                                   {
                                                       Id = 3,
                                                       Name = "Greenberry",
                                                       Timezone = "Australian Western Standard Time"
                                                   });


            var asm = Assembly.GetExecutingAssembly();
            var rng = new Random();


            //read all of the comments
            var comments = new List<string>();
            using (var commentsStream = asm.GetManifestResourceStream("RateIt.TechnicalTest.Data.SeedData.comments.txt"))
            using (var commentsTextReader = new StreamReader(commentsStream))
            {
                while (!commentsTextReader.EndOfStream)
                {
                    comments.Add(commentsTextReader.ReadLine());
                }
            }

            using (var stream = asm.GetManifestResourceStream("RateIt.TechnicalTest.Data.SeedData.ratings.csv"))
            using (var ratingsTextReader = new StreamReader(stream))
            using (var csvReader = new CsvReader(ratingsTextReader))
            {
                var records = csvReader.GetRecords(new
                {
                    CompanyId = 1,
                    DateRecorded = DateTimeOffset.Now,
                    Nps = (int?)0
                });

                var ratingId = 1;
                var resultId = 1;
                var ratings = new List<Rating>();
                var results = new List<RatingResult>();
                foreach (var record in records)
                {
                    var rating = new Rating
                    {
                        Id = ratingId++,
                        CompanyId = record.CompanyId,
                        DateRecorded = record.DateRecorded
                    };
                    ratings.Add(rating);

                    if (record.Nps.HasValue)
                    {
                        results.Add(new RatingResult
                        {
                            Id = resultId++,
                            RatingId = rating.Id,
                            ResultType = RatingResultType.Nps,
                            Value = record.Nps.Value.ToString()
                        });
                    }

                    var commentIndex = rng.Next(0, comments.Count + 5);
                    if (commentIndex < comments.Count)
                    {
                        results.Add(new RatingResult
                        {
                            Id = resultId++,
                            RatingId = rating.Id,
                            ResultType = RatingResultType.Comment,
                            Value = comments[commentIndex]
                        });
                    }
                }

                modelBuilder.Entity<Rating>().HasData(ratings.ToArray());
                modelBuilder.Entity<RatingResult>().HasData(results.ToArray());
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
