using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace SolarSystem.Services
{
    public class Questions
    {
        private readonly IDb _Db;

        public Questions(IDb db)
        {
            _Db = db;
        }
        public List<string> Question1()
        {
            return _Db.GetAllItemsOfTypePlanet().OrderBy(i => i.Name).Select(i => i.Name).ToList();
        }
        public List<string> Question2()
        {
            return _Db.GetAllItemsOfTypePlanet().Where(i => i.SurfaceTempMax > 0).Select(i => i.Name).ToList();
        }
        public List<string> Question3()
        {
            return _Db.GetAllItemsOfTypePlanet().Where(i => i.Name.ToUpper().Contains("P") || i.Name.ToUpper().Contains("T")).Select(i => i.Name).ToList();
        }
        public List<string> Question4()
        {
            return _Db.GetAllItemsOfTypePlanet().OrderByDescending(i => i.Name.Length).Select(i => i.Name).ToList();
        }
        public List<string> Question5()
        {
            return _Db.GetAllItemsOfTypePlanet().OrderBy(i => i.OrbitDistance).Select(i => i.Name).ToList();
        }
        public List<string> Question6()
        {
            return _Db.GetAllItemsOfTypePlanet().OrderBy(i => i.OrbitDistance).Select(i => i.Name).ToList();
        }
        public List<string> Question7()
        {
            return _Db.GetAllItemsOfTypePlanet().Where(i => i.Class == Core.Models.Planet.TypeOfPlanet.DwarfPlanet).OrderBy(i => i.KnownMoons).Select(i => i.Name).ToList();
        }
        public short Question8()
        {
            short amountOfMoons = 0;
            foreach (var item in _Db.GetAllItemsOfTypePlanet())
            {
                amountOfMoons += item.KnownMoons;
            }

            return amountOfMoons;
        }
        public List<string> Question9()
        {
            return _Db.GetAllItemsOfTypePlanet().Where(i => i.Class == Core.Models.Planet.TypeOfPlanet.DwarfPlanet).OrderBy(i => i.Diameter).Select(i => i.Name).ToList();
        }

        public double Question10()
        {
            short amountOfMoons = 0;
            foreach (var item in _Db.GetAllItemsOfTypePlanet())
            {
                amountOfMoons += item.KnownMoons;
            }

            return amountOfMoons / _Db.GetAllItemsOfTypePlanet().Count;
        }

        public (double avgPlanet, double avgDwarfPlanet) Question11()
        {
            double totalPlanetTemp = 0;
            byte totalPlanets = 0;
            double totalDwarfPlanetTemp = 0;
            byte totalDwarfPlanets = 0;

            foreach (var item in _Db.GetAllItemsOfTypePlanet())
            {
                switch (item.Class)
                {
                    case Core.Models.Planet.TypeOfPlanet.Planet:
                        totalPlanets++;
                        totalPlanetTemp += item.SurfaceTempMax;
                        totalPlanetTemp += item.SurfaceTempMin;
                        break;
                    case Core.Models.Planet.TypeOfPlanet.DwarfPlanet:
                        totalDwarfPlanets++;
                        totalDwarfPlanetTemp += item.SurfaceTempMax;
                        totalDwarfPlanetTemp += item.SurfaceTempMin;
                        break;
                    default:
                        break;
                }
            }

            totalPlanetTemp /= 2;
            totalDwarfPlanetTemp /= 2;

            return (totalPlanetTemp / totalPlanets, totalDwarfPlanetTemp / totalDwarfPlanets);
        }

        public int Question12()
        {
            short amountOfMoons = 0;
            foreach (var item in _Db.GetAllItemsOfTypePlanet())
            {
                amountOfMoons += item.KnownMoons;
            }

            return amountOfMoons + _Db.GetAllItemsOfTypePlanet().Count + _Db.GetAllItemsOfTypeStar().Count;
        }

        public (string planet1,string planet2) Question13()
        {
            string planet1 = default(string);
            string planet2 = default(string);
            long shortestDistance = int.MaxValue;
            foreach (var item in _Db.GetAllItemsOfTypePlanet())
            {
                foreach (var item2 in _Db.GetAllItemsOfTypePlanet())
                {
                    if (item.OrbitDistance - item2.OrbitDistance < shortestDistance)
                    {
                        planet1 = item.Name;
                        planet2 = item2.Name;
                        shortestDistance = item.OrbitDistance - item2.OrbitDistance;
                    }
                }
            }

            return (planet1, planet2);
        }
    }
}
