using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class Last : LinqMethod
    {
        public Last(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var lastCar = Cars.Last(x => x.Price == 30);
            Console.WriteLine("\tLast car - " + lastCar.Name);
            Console.WriteLine("\tNo car.. throws Exception ");
            var noLastCar = Cars.Last(x => x.Price > 50);
        }
    }
}
