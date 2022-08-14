using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            carManager.Add(new Car
            {
                Id = 6,
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 700,
                ModelYear = 2020,
                Description = "Ekonomik"
            });

            carManager.Update(new Car
            {
                Id = 6,
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 70000000,
                ModelYear = 2020,
                Description = "Ekonomik"
            });

            carManager.Delete(new Car
            {
                Id = 6,
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }

            foreach (var c in carManager.GetById(2))
            {
                Console.WriteLine(c.ModelYear);
            }


        }
    }
}