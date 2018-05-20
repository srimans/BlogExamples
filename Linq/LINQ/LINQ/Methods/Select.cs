using System;
using LINQ.Models;
using System.Linq;

namespace LINQ.Methods
{
    public class Select : LinqMethod
    {
        public Select(Car[] cars) : base(cars)
        {
        }

        protected override void ExecuteCore()
        {
            var carName = Cars.Select(x => x.Name);

            Console.WriteLine("\tCar Names");
            DisplayCars(carName.ToArray());
        }

        private void DisplayCars(string[] carName)
        {
            foreach (var name in carName)
            {
                Console.WriteLine("\t" + name);
            }
        }
    }
}
