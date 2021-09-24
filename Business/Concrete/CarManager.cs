using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Caching;
using Core.Aspect.Autofac.Performance;
using Core.Aspect.Autofac.Transaction;
using Core.Aspect.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
     

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
         
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            var result = BusinessRules.Run(CheckIfCarNameExist(car.CarName),
                CheckIfCarCountOfBrandCorrect(car.CarBrandId));
            if (result!=null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);


        }

        public IDataResult<List<CarDetailDto>> CarDetailDtos()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetDetailDtos(),
                Messages.CarsDetailsListed);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted);       
                }

        [SecuredOperation("Admin,Cars.GetAll")]
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        [PerformanceAspect(interval:5)]
        public IDataResult<Car> GetById(int carId)
        {
            Thread.Sleep(millisecondsTimeout: 5000);
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId),Messages.CarListed);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

       private IResult  CheckIfCarNameExist(string carName)
        {
            var result = _carDal.Get(c => c.CarName == carName);
            if (result!=null)
            {
                return new ErrorResult(Messages.CarNameAlreadyExist);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarCountOfBrandCorrect(int brandId)
        {
            var result = _carDal.GetAll(c => c.CarBrandId == brandId).Count;
            if (result>10)
            {
                return new ErrorResult(Messages.CarCountOfBrandError);
            }
            return new SuccessResult();
        }

        [TransactionScopeAspect]
       public IResult TransactionTest(Car car)
        {
            _carDal.Add(car);
            if (car.CarDailyPrice>50)
            {
                throw new Exception("");
            }
            _carDal.Add(car);
            return new SuccessResult();

        }
    }
}
