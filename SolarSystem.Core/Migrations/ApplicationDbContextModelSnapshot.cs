﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolarSystem.Core.Models;

namespace SolarSystem.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("SolarSystem.Core.Models.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<long>("Diameter")
                        .HasColumnType("bigint");

                    b.Property<byte>("KnownMoons")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OrbitDistance")
                        .HasColumnType("bigint");

                    b.Property<double>("OrbitPeriod")
                        .HasColumnType("float");

                    b.Property<double>("SurfaceTempMax")
                        .HasColumnType("float");

                    b.Property<double>("SurfaceTempMin")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = 0,
                            Diameter = 4879L,
                            KnownMoons = (byte)0,
                            Name = "Mercury",
                            OrbitDistance = 57900000L,
                            OrbitPeriod = 88.0,
                            SurfaceTempMax = 173.0,
                            SurfaceTempMin = -427.0
                        },
                        new
                        {
                            Id = 2,
                            Class = 0,
                            Diameter = 12104L,
                            KnownMoons = (byte)0,
                            Name = "Venus",
                            OrbitDistance = 108200000L,
                            OrbitPeriod = 224.69999999999999,
                            SurfaceTempMax = 462.0,
                            SurfaceTempMin = 462.0
                        },
                        new
                        {
                            Id = 3,
                            Class = 0,
                            Diameter = 12756L,
                            KnownMoons = (byte)1,
                            Name = "Earth",
                            OrbitDistance = 149600000L,
                            OrbitPeriod = 365.19999999999999,
                            SurfaceTempMax = 58.0,
                            SurfaceTempMin = -88.0
                        },
                        new
                        {
                            Id = 4,
                            Class = 0,
                            Diameter = 6805L,
                            KnownMoons = (byte)2,
                            Name = "Mars",
                            OrbitDistance = 227900000L,
                            OrbitPeriod = 693.5,
                            SurfaceTempMax = -63.0,
                            SurfaceTempMin = -63.0
                        },
                        new
                        {
                            Id = 5,
                            Class = 1,
                            Diameter = 950L,
                            KnownMoons = (byte)0,
                            Name = "Ceres",
                            OrbitDistance = 413700000L,
                            OrbitPeriod = 1678.9999999999998,
                            SurfaceTempMax = -105.0,
                            SurfaceTempMin = -105.0
                        },
                        new
                        {
                            Id = 6,
                            Class = 0,
                            Diameter = 142984L,
                            KnownMoons = (byte)67,
                            Name = "Jupiter",
                            OrbitDistance = 778300000L,
                            OrbitPeriod = 4343.5,
                            SurfaceTempMax = -108.0,
                            SurfaceTempMin = -108.0
                        },
                        new
                        {
                            Id = 7,
                            Class = 0,
                            Diameter = 120536L,
                            KnownMoons = (byte)62,
                            Name = "Saturn",
                            OrbitDistance = 1400000000L,
                            OrbitPeriod = 10767.5,
                            SurfaceTempMax = -139.0,
                            SurfaceTempMin = -139.0
                        },
                        new
                        {
                            Id = 8,
                            Class = 0,
                            Diameter = 51118L,
                            KnownMoons = (byte)27,
                            Name = "Uranus",
                            OrbitDistance = 2900000000L,
                            OrbitPeriod = 30660.0,
                            SurfaceTempMax = -197.0,
                            SurfaceTempMin = -197.0
                        },
                        new
                        {
                            Id = 9,
                            Class = 0,
                            Diameter = 49528L,
                            KnownMoons = (byte)14,
                            Name = "Neptune",
                            OrbitDistance = 4500000000L,
                            OrbitPeriod = 60152.000000000007,
                            SurfaceTempMax = -201.0,
                            SurfaceTempMin = -201.0
                        },
                        new
                        {
                            Id = 10,
                            Class = 1,
                            Diameter = 2306L,
                            KnownMoons = (byte)5,
                            Name = "Uranus",
                            OrbitDistance = 5900000000L,
                            OrbitPeriod = 89790.0,
                            SurfaceTempMax = -229.0,
                            SurfaceTempMin = -229.0
                        });
                });

            modelBuilder.Entity("SolarSystem.Core.Models.Star", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("Age")
                        .HasColumnType("bigint");

                    b.Property<byte>("AmountOfOrbitingPlanets")
                        .HasColumnType("tinyint");

                    b.Property<long>("CoreTemp")
                        .HasColumnType("bigint");

                    b.Property<long>("Diameter")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SurfaceTempMax")
                        .HasColumnType("float");

                    b.Property<double>("SurfaceTempMin")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Stars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 4600000000L,
                            AmountOfOrbitingPlanets = (byte)13,
                            CoreTemp = 15000000L,
                            Diameter = 1392684L,
                            Name = "Sun",
                            SurfaceTempMax = 5500.0,
                            SurfaceTempMin = 5500.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
