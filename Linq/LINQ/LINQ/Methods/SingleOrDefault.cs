using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class SingleOrDefault : LinqMethod
    {
        public SingleOrDefault(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var onlyOneCar = Cars.SingleOrDefault(x => x.Price == 40);

            Console.WriteLine("\tOnly one car - " + onlyOneCar.Name);
            Console.WriteLine("\tNo car.. returns default value ");
            var noCar = Cars.SingleOrDefault(x => x.Price > 50);
            Console.Write(noCar ?? null);
            Console.WriteLine("\tMore than one car.. throws Exception ");
            var moreThanOneCar = Cars.SingleOrDefault(x => x.Price == 50); 
        }
    }
}
