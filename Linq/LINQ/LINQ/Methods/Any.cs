using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class Any : LinqMethod
    {
        public Any(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var isAnyCar = Cars.Any();
            var isAnyCarWithAPriceGreaterThanThirty = Cars.Any(x => x.Price > 30);

            Console.Write("\tAny Car - " + isAnyCar);
            Console.WriteLine("\n\tIs there any car with a price greater than 30 - " + isAnyCarWithAPriceGreaterThanThirty);
        }
    }
}
