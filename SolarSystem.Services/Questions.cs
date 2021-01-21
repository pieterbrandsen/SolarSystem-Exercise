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

        public int Question12()
        {
            short amountOfMoons = 0;
            foreach (var item in _Db.GetAllItemsOfTypePlanet())
            {
                amountOfMoons += item.KnownMoons;
            }

            return amountOfMoons + _Db.GetAllItemsOfTypePlanet().Count + _Db.GetAllItemsOfTypeStar().Count;
        }
    }
}
