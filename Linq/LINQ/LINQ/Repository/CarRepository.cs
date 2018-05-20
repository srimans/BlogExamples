using LINQ.Models;

namespace LINQ.Repository
{
    public sealed class CarRepository
    {
        public Car[] Car => new Car[]
        {
            new Car { Id = 1, Name = "Maruti", Price = 50 },
            new Car { Id = 2, Name = "BMW", Price = 40 },
            new Car { Id = 3, Name = "Audi", Price = 30 },
            new Car { Id = 4, Name = "Chevrolet", Price = 20 },
            new Car { Id = 5, Name = "Hyundai", Price = 50 },
        };
    }
}
