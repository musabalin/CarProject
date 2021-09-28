using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //ColorAddTest();
            //ColorDeleteTest();
            //BrandUpdateTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }

        }

        private static void BrandUpdateTest()
        {
            Brand brand1 = new Brand() { BrandId = 1, BrandName = "Honda" };
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brand1.BrandName = "BMW";
            brandManager.Update(brand1);
        }

        private static void ColorDeleteTest()
        {
            ColorManager color = new ColorManager(new EfColorDal());
            Color color1 = new Color();
            Console.Write("ColorId:");
            color1.ColorId = Convert.ToInt32(Console.ReadLine());
            var result = color.GetAll().Where(x => x.ColorId == color1.ColorId);
            color.Delete(color1);
        }

        private static void ColorAddTest()
        {
            ColorManager color = new ColorManager(new EfColorDal());
            Color color1 = new Color();
            Console.Write("ColorId:");
            color1.ColorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("ColorName:");
            color1.ColorName = Console.ReadLine();
            color.Add(color1);
        }

        private static void CarTest()
        {
            Car car1 = new Car();
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Arabanın ..");
            Console.Write("Id:");
            car1.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("BrandId:");
            car1.BrandId = Convert.ToInt32(Console.ReadLine());
            Console.Write("ColorId:");
            car1.ColorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name:");
            car1.CarName = Console.ReadLine();
            Console.Write("Model Year:");
            car1.ModelYear = Console.ReadLine();
            Console.Write("DailyPrice Year:");
            car1.DailyPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Description:");
            car1.Description = Console.ReadLine();

            carManager.Add(car1);


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
