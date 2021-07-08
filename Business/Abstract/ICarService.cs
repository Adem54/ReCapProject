using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {

        List<Car> GetAll();

        List<Car> GetByColors(int colorId);
        List<Car> GetByBrands(int brandId);

        Car GetById(int carId);

        void Add(Car car);

        void Delete(Car car);

        void Update(Car car);
    }
}
