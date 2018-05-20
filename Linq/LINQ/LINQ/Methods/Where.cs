using LINQ.Models;
using System;
using System.Linq;

namespace LINQ.Methods
{
    public class Where : LinqMethod
    {
        public Where(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var cars = Cars.Where(x => x.Price > 30);

            Console.WriteLine("\tCars with price greater than 30");
            DisplayCars(cars.ToArray());
        }

        private void DisplayCars(Car[] cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine("\t" + car.Name);
            }
        }
    }
}
