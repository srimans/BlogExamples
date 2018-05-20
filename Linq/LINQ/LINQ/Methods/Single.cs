using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class Single : LinqMethod
    {
        public Single(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var onlyOneCar = Cars.Single(x => x.Price == 40); 

            Console.WriteLine("\tOnly one car - " + onlyOneCar.Name);
            Console.WriteLine("\tNo car.. throws Exception ");

            var noCar = Cars.Single(x => x.Price > 50);

            Console.WriteLine("\tMore than one car.. throws Exception ");
            var moreThanOneCar = Cars.Single(x => x.Price == 50); 
        }
    }
}
