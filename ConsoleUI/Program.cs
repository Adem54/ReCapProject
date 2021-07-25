using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryData;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


          

            

            Car car4 = new Car
            {
               
                CarBrandId = 2,
                CarColorId = 1,
                CarName="Yeni eklenene Araba1",
                CarModelYear = 2018,
                CarDailyPrice = 126,
                Description = "Az yakar cok kacar!"
            };
            Car car5 = new Car
            {
                CarId=1010,
                CarBrandId = 1,
                CarColorId = 1,
                CarName="N",
                CarModelYear = 2016,
                CarDailyPrice = 120,
                Description = "Kusursuz!"
            };
            Car car6 = new Car
            {
                CarId=1,
                CarBrandId = 2,
                CarColorId = 2,
                CarModelYear = 2009,
                CarDailyPrice = 77,
                Description = "Araba guncellendi!"
            };

            EfCarDal carDal = new EfCarDal();

            CarManager carManager = new CarManager(carDal);

           // carManager.Delete(car5);
            // carManager.Add(car4);
            // carManager.Add(car2);
            carManager.Update(car6);

            foreach (var car in carManager.CarDetailDtos())
            {
                Console.WriteLine(car.CarName+" |  Brand: "+ car.BrandName+ " ColorName: "+ car.ColorName);
            }

            Console.WriteLine("--------------------------------");

            var carDetails = carManager.GetById(4);

            Console.WriteLine(carDetails.Description);

         
           // carManager.Delete(car2);
           // carManager.Delete(car3);

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            Console.ReadLine();
        }
    }
}
