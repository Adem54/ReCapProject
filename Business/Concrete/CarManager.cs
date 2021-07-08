using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;//Dependency injection yolu ile DataAccess in methodlarini kullanabiliriz..
     

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
         
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrands(int brandId)
        {
            return _carDal.GetByBrands(brandId);
        }

        public List<Car> GetByColors(int colorId)
        {
            return _carDal.GetByColors(colorId); 
        }

        public Car GetById(int carId)
        {
            return _carDal.GetById(carId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
