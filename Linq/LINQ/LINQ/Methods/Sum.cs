using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class Sum : LinqMethod
    {
        public Sum(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var sum = Cars.Sum(x => x.Price);

            Console.WriteLine("\tTotal price of all cars - " + sum);
        }
    }
}
