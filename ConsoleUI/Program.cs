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
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(@"{0} / {1} / {2} / {3}",car.BrandName,car.Model,car.ColorName,car.DailyPrice);
            }

            //carManager.Add(new Car { ModelYear = 2020, Description = "2020 BMW", DailyPrice = 200, ColorId = 2, BrandId = 1 });
            //carManager.Delete(new Car {ModelYear = 2020, Description = "2020 BMW", DailyPrice = 200, ColorId = 2, BrandId = 1 });

        }
    }
}
