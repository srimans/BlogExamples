using LINQ.Methods;
using LINQ.Repository;
using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new CarRepository();
            var cars = repository.Car;

            var steps = new LinqMethod[]
            {
                new Where(cars),
                new Select(cars),
                new Any(cars),
                new All(cars),
                new Count(cars),
                new Sum(cars),
                new First(cars),
                new FirstOrDefault(cars),
                new Methods.Single(cars),
                new SingleOrDefault(cars),
                new Last(cars),
                new LastOrDefault(cars)
            };

            foreach(var step in steps)
            {
                if (!step.Execute()) break;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
