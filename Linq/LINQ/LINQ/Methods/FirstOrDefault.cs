using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class FirstOrDefault : LinqMethod
    {
        public FirstOrDefault(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var firstOrDefault = Cars.FirstOrDefault(x => x.Price == 50);

            Console.WriteLine("\tFirst car - " + firstOrDefault.Name);
            Console.Write("\tNo first car.. returns default value ");

            var firstOrDefaultCar = Cars.FirstOrDefault(x => x.Price == 60);

            Console.WriteLine(firstOrDefaultCar ?? null);
        }
    }
}
