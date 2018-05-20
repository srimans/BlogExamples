using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class All : LinqMethod
    {
        public All(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var doesAllCarHavePriceGreaterThanZero = Cars.All(x => x.Price > 0);
            var doesAllCarHavePriceGreaterThanThirty = Cars.All(x => x.Price > 30);

            Console.Write("\tAre all cars with price greater than 0 - " + doesAllCarHavePriceGreaterThanZero);
            Console.WriteLine("\n\tAll Cars with price greater than 30 - " + doesAllCarHavePriceGreaterThanThirty);
        }
    }
}
