using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            CarManager carManager = new CarManager(new EFCarDal());
            //Console.WriteLine("Arabanın ..");
            //Console.Write("Id:");
            //car1.Id = Convert.ToInt32(Console.ReadLine());
            //Console.Write("BrandId:");
            //car1.BrandId = Convert.ToInt32(Console.ReadLine());
            //Console.Write("ColorId:");
            //car1.ColorId = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Model Year:");
            //car1.ModelYear = Console.ReadLine();
            //Console.Write("DailyPrice Year:");
            //car1.DailyPrice = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Description:");
            //car1.Description = Console.ReadLine();

            //carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
