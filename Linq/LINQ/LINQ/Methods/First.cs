using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class First : LinqMethod
    {
        public First(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var firstCar = Cars.First(x => x.Price == 50);

            Console.WriteLine("\tFirst car - " + firstCar.Name);
            Console.WriteLine("\tNo first car.. throws Exception ");
            var noFirstCar = Cars.First(x => x.Price > 50); 
        }
    }
}
