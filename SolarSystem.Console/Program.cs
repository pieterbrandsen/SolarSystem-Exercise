using System;
using Microsoft.Extensions.DependencyInjection;
using SolarSystem.Core.Models;
using SolarSystem.Services;

namespace SolarSystem.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
.AddSingleton<IDb, Db>().AddDbContext<ApplicationDbContext>()
.BuildServiceProvider();

            var questions = new Questions(serviceProvider.GetService<IDb>());
            var questions1List = questions.Question1();
            System.Console.WriteLine("Question 1 answers");
            foreach (var item in questions1List)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
