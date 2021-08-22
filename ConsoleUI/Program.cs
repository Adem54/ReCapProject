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
            // carManager.Update(car6);

            //if (carManager.CarDetailDtos().Success)
            //{
            //    foreach (var car in carManager.CarDetailDtos().Data)
            //    {
            //        Console.WriteLine(car.CarName + " |  Brand: " + car.BrandName + " ColorName: " + car.ColorName);
            //    }
            //    Console.WriteLine(carManager.CarDetailDtos().Message);
            //}
            //else
            //{
            //    Console.WriteLine(carManager.CarDetailDtos().Message);
            //}

           
           

            //Console.WriteLine("--------------------------------");

            //var result = carManager.GetAll();
            //if (result.Success==true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.Description);
            //    }
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //Console.WriteLine("Customer CRUD OPERASYONLARI");

            //Customer customer1 = new Customer {CustomerId=4, UserId = 3, CompanyName = "Brothers Industri" };

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());


            ////Console.WriteLine(customerManager.Update(customer1).Message);

            //Console.WriteLine("Rental Test");
            //Rental rental1 = new Rental
            //{
            //    CarId = 3,
            //    CustomerId = 4,
            //    RentDate = new DateTime(2021, 4, 23),
            //    ReturnDate = new DateTime(2021,11,22)
            //};

           
            //Console.WriteLine("RentalDetailDto");
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //var result1 = rentalManager.GetRentalDetailDtos();
            //if (result1.Success)
            //{
            //    foreach (var rentalDetail in result1.Data)
            //    {
            //        Console.WriteLine(rentalDetail.CarName+ " | "+ rentalDetail.CompanyName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result1.Message);
            //}

            //Console.WriteLine("Test rentalManagerAdd")
                
            //    ;
            //Console.WriteLine(rentalManager.Add(rental1).Message);

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
