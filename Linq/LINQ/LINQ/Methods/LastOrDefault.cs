using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class LastOrDefault : LinqMethod
    {
        public LastOrDefault(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var lastCar = Cars.LastOrDefault(x => x.Price == 30);

            Console.WriteLine("\tLast car - " + lastCar.Name);

            var noLastCar = Cars.LastOrDefault(x => x.Price > 50);

            Console.Write("\tNo last car.. returns default value ");
            Console.WriteLine(noLastCar ?? null);
        }
    }
}
