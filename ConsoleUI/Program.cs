using Business.Concreate;
using Core.DataAccess;
using DataAccess.Concreate.IEntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            //CarAdded();
            //ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager color = new ColorManager(new EfColorDal());
            var result = color.GetById(2);
            if (result.Succes) Console.WriteLine(result.Message);
            else Console.WriteLine(result.Message);
        }

        private static void CarAdded()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = 20000, Description = "m" });

            if (result.Succes)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carmanager = new CarManager(new EfCarDal());

            foreach (var car in carmanager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
