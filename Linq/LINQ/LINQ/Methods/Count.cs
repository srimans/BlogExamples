using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class Count : LinqMethod
    {
        public Count(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var totalCars = Cars.Count();
            var totalCarsWithPriceGreaterThanThirty = Cars.Count(x => x.Price > 30);

            Console.Write("\tTotal Cars - " + totalCars);
            Console.WriteLine("\n\tCars with a price greater than 30 - " + totalCarsWithPriceGreaterThanThirty);
        }
    }
}
