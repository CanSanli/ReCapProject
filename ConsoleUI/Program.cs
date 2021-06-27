using Business.Concrete;
using Entities.Concrete;
using System;

using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Delete(new Car { ModelYear = 2020, Description = "2020 BMW", DailyPrice = 200, ColorId = 2, BrandId = 1 });

        }
    }
}
