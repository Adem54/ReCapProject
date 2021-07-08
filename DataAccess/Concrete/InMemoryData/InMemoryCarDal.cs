using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryData
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            
            new Car{CarId=1, CarBrandId=1, CarColorId=1, CarModelYear=2018, DailyPrice=240, Description="Birinci sahibinden" },
            new Car{CarId=2, CarBrandId=1, CarColorId=2, CarModelYear=2016, DailyPrice=200, Description="Full bakimli " },
            new Car{CarId=3, CarBrandId=2, CarColorId=2, CarModelYear=2017, DailyPrice=220, Description=" Teknik Servis Bakimli" },
            new Car{CarId=4, CarBrandId=2, CarColorId=1, CarModelYear=2019, DailyPrice=250, Description=" Degisen yok " },
            new Car{CarId=5, CarBrandId=1, CarColorId=2, CarModelYear=2020, DailyPrice=280, Description=" Dusuk km de " },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrands(int brandId)
        {
            var cars = _cars.Where(p => p.CarBrandId == brandId).ToList();
            return cars;
        }

        public List<Car> GetByColors(int colorId)
        {
            var cars= _cars.Where(p => p.CarColorId == colorId).ToList();
            return cars;
           
            
        }

        public Car GetById(int carId)
        {
            return _cars.First(p => p.CarId == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(p => p.CarId == car.CarId);

            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
