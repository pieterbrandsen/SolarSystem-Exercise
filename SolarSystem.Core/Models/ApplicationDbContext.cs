using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolarSystem.Core.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Star> Stars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("defaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Star>().HasData(new Star { Name="Sun", Age = 4600000000, AmountOfOrbitingPlanets = 13, CoreTemp = 15000000, Diameter = 1392684, SurfaceTempMax = 5500, SurfaceTempMin = 5500, Id = 1 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Mercury", Diameter = 4879, KnownMoons = 0, OrbitDistance = 57900000, OrbitPeriod = 88.0, SurfaceTempMax = 173, SurfaceTempMin = -427, Class = Planet.TypeOfPlanet.Planet, Id = 1 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Venus", Diameter = 12104, KnownMoons = 0, OrbitDistance = 108200000, OrbitPeriod = 224.7, SurfaceTempMax = 462, SurfaceTempMin = 462, Class = Planet.TypeOfPlanet.Planet, Id = 2 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Earth", Diameter = 12756, KnownMoons = 1, OrbitDistance = 149600000, OrbitPeriod = 365.2, SurfaceTempMax = 58, SurfaceTempMin = -88, Class = Planet.TypeOfPlanet.Planet, Id = 3 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Mars", Diameter = 6805, KnownMoons = 2, OrbitDistance = 227900000, OrbitPeriod = 1.9*365, SurfaceTempMax = -63, SurfaceTempMin = -63, Class = Planet.TypeOfPlanet.Planet, Id = 4 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Ceres", Diameter = 950, KnownMoons = 0, OrbitDistance = 413700000, OrbitPeriod = 4.6*365, SurfaceTempMax = -105, SurfaceTempMin = -105, Class = Planet.TypeOfPlanet.DwarfPlanet, Id = 5 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Jupiter", Diameter = 142984, KnownMoons = 67, OrbitDistance = 778300000, OrbitPeriod = 11.9*365, SurfaceTempMax = -108, SurfaceTempMin = -108, Class = Planet.TypeOfPlanet.Planet, Id = 6 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Saturn", Diameter = 120536, KnownMoons = 62, OrbitDistance = 1400000000, OrbitPeriod = 29.5*365, SurfaceTempMax = -139, SurfaceTempMin = -139, Class = Planet.TypeOfPlanet.Planet, Id = 7 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Uranus", Diameter = 51118, KnownMoons = 27, OrbitDistance = 2900000000, OrbitPeriod = 84*365, SurfaceTempMax = -197, SurfaceTempMin = -197, Class = Planet.TypeOfPlanet.Planet, Id = 8 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Neptune", Diameter = 49528, KnownMoons = 14, OrbitDistance = 4500000000, OrbitPeriod = 164.8*365, SurfaceTempMax = -201, SurfaceTempMin = -201, Class = Planet.TypeOfPlanet.Planet, Id = 9 });
            modelBuilder.Entity<Planet>().HasData(new Planet { Name = "Uranus", Diameter = 2306, KnownMoons = 5, OrbitDistance = 5900000000, OrbitPeriod = 246 * 365, SurfaceTempMax = -229, SurfaceTempMin = -229, Class = Planet.TypeOfPlanet.DwarfPlanet, Id = 10 });

            // Linkquery, zoek op p en t
        }
    }
}
