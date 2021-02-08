using Microsoft.EntityFrameworkCore;
using SolarSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolarSystem.Services
{
    public interface IDb
    {
        public T GetItemUsingName<T>(string itemName);
        public T GetItemUsingId<T>(string itemId);
        public List<Planet> GetAllItemsOfTypePlanet();
        public List<Star> GetAllItemsOfTypeStar();
    }
    public class Db : IDb
    {
        private readonly ApplicationDbContext _context;

        public Db(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Planet> GetAllItemsOfTypePlanet()
        {
            return _context.Planets.ToList();
        }

        public List<Star> GetAllItemsOfTypeStar()
        {
            return _context.Stars.ToList();
        }

        public T GetItemUsingId<T>(string itemId)
        {
            throw new NotImplementedException();
        }

        public T GetItemUsingName<T>(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}
