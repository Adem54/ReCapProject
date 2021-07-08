using Business.Concrete;
using DataAccess.Concrete.InMemoryData;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();


            CarManager carManager = new CarManager(inMemoryCarDal);

            Car car1 = new Car() { CarId = 6, CarBrandId = 5, CarColorId = 6, CarModelYear = 2021, DailyPrice = 320,
                Description = "Kusursuz arac!" };
            Car car2 = new Car()
            {
                CarId = 1,
                CarBrandId = 4,
                CarColorId = 8,
                CarModelYear = 2021,
                DailyPrice = 320,
                Description = " Bayandan Az kullanilmis!  "
            };

            Car car3 = new Car
            {
                CarId = 2,
                CarBrandId = 1,
                CarColorId = 2,
                CarModelYear = 2016,
                DailyPrice = 200,
                Description = "Full bakimli "
            };

            carManager.Add(car1);


            Console.WriteLine("----------GetById--------");

            int carId=carManager.GetById(5).CarId;
            int carColorId = carManager.GetById(5).CarColorId;
            int carBrandId = carManager.GetById(5).CarBrandId;
            int carModelYear = carManager.GetById(5).CarModelYear;
            decimal carDailyPrice = carManager.GetById(5).DailyPrice;
            string carDescription = carManager.GetById(5).Description;

            Console.WriteLine("CarId: "+ carId+ " carColorId: "+ carColorId+ " carBrandId: "+ carBrandId +
                "  carModelYear:" + carModelYear + " carDailyPrice: "+ carDailyPrice + " carDescription: "+ carDescription);

            Console.WriteLine("--------------------------------------------------------");
            //Renge gore filtreleme
            foreach (var color in carManager.GetByColors(2))
            {
                Console.WriteLine("REnge gore sirala: "+"ColorId:  " +color.CarColorId + color.Description);
            }

            Console.WriteLine("--------------------------------------------------------");

            //Modele gore filtreleme
            foreach (var brand in carManager.GetByBrands(1))
            {
                Console.WriteLine("Modele gore sirala: " + "BrandId:  " + brand.CarBrandId + brand.Description);
            }
          
          
            
            Console.WriteLine("............................................");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId+ "-|-"+"BrandId: " +car.CarBrandId+" | "+" ColorId: " +car.CarColorId+ " | "  +car.Description);
            }



            Console.ReadLine();
        }
    }
}
