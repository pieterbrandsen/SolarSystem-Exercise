using Microsoft.Extensions.DependencyInjection;
using SolarSystem.Core.Models;
using SolarSystem.Services;

namespace SolarSystem.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
.AddSingleton<IDb, Db>().AddDbContext<ApplicationDbContext>().AddScoped<IDb, Db>()
.BuildServiceProvider();

            var questions = new Questions(serviceProvider.GetService<IDb>());
            var questions1List = questions.Question1();
            System.Console.WriteLine("Question 1 answers");
            foreach (var item in questions1List)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Question 2 answers");
            var questions2List = questions.Question2();
            foreach (var item in questions2List)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Question 3 answers");
            var questions3List = questions.Question3();
            foreach (var item in questions3List)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Question 4 answers");
            var questions4List = questions.Question4();
            foreach (var item in questions4List)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Question 5 answers");
            var questions5List = questions.Question5();
            foreach (var item in questions5List)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Question 6 answers");
            var questions6List = questions.Question6();
            foreach (var item in questions6List)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Question 7 answers");
            var questions7List = questions.Question7();
            foreach (var item in questions7List)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Question 8 answers");
            var questions8 = questions.Question8();
                System.Console.WriteLine(questions8);


            System.Console.WriteLine();
            System.Console.WriteLine("Question 9 answers");
            var questions9List = questions.Question9();
            foreach (var item in questions9List)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Question 10 answers");
            var questions10 = questions.Question10();
            System.Console.WriteLine(questions10);

            System.Console.WriteLine();
            System.Console.WriteLine("Question 11 answers");
            var questions11 = questions.Question11();
            System.Console.WriteLine($"Avg Temp Planets: {questions11.avgPlanet}");
            System.Console.WriteLine($"Avg Temp DwarfPlanets: {questions11.avgDwarfPlanet}");

            System.Console.WriteLine();
            System.Console.WriteLine("Question 12 answers");
            var questions12 = questions.Question12();
            System.Console.WriteLine(questions12);

            System.Console.WriteLine();
            System.Console.WriteLine("Question 13 answers");
            var questions13 = questions.Question13();
            System.Console.WriteLine($"Planet 1: {questions13.planet1}");
            System.Console.WriteLine($"Planet 2: {questions13.planet2}");

            System.Console.ReadKey();
        }
    }
}