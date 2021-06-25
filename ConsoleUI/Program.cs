using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            //++++++++++++++++++++++++++++++++++++++++++++++

            //Console.WriteLine(carManager.GetById(1).Description);

            //++++++++++++++++++++++++++++++++++++++++++++++

            carManager.Add(new Car { Id = 2, ColorId = 1, BrandId = 2, Description = "Mercedes", DailyPrice = 350, ModelYear = 2018 });
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            //++++++++++++++++++++++++++++++++++++++++++++++

            carManager.Update(new Car { Id = 1, BrandId = 2, ColorId = 3, DailyPrice = 500, ModelYear = 2020, Description = "Tofaş" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            //++++++++++++++++++++++++++++++++++++++++++++++

            carManager.Delete(new Car { Id = 1 });
            Console.WriteLine();
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
