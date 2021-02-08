using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SolarSystem.Core.Models;

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
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=database;Trusted_Connection=True;MultipleActiveResultSets=true";

        public Db(ApplicationDbContext context)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(_connectionString).Options;
            // With the options generated above, we can then just construct a new DbContext class

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