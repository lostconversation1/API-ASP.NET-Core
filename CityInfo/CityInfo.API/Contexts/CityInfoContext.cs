using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Contexts
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City()
            {
                Id = 1,
                Name = "DG City",
                Description = "thE one with park",

            },
                new City()
                {
                    Id = 2,
                    Name = "Bedzin",
                    Description = "regular one",

                },
                new City()
                {
                    Id = 3,
                    Name = "Sosnowiec",
                    Description = "the one from jokes",

                });

            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest()
                {
                    Id = 1,
                    Name = "1ssss as",
                    CityId = 1
                },
                new PointOfInterest()
                {
                    Id = 2,
                    Name = "2ssss as",
                    CityId = 1
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
