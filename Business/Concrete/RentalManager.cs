using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate>DateTime.Now)
            {
                return new ErrorResult(Messages.RentalAddedFailed);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }
        //_rentalDal.GetAll() ile veritabanimizdaki Rental listesine ulasiyorduk
        //Add methodunda sunu da yapabilirdik Rentals veritabanindaki listemizde once parametreden
        //gelen rentalda  ile gelen  aracin id si listeden hangi aracin id sine  denk geliyor
        //onu bulurduk nasil bbulurduk foreach ile listelerdik ve id leri karsilastirirdik
        //Sonrra da listemizde buldugumuz aracin ReturnDate i eger parametredden  gelen aracin
        //RentDate inden buyuk ise yani bu demektir ki listemizde buldugumuz aracin teslim 
        //edilis tarihi parametreden gelen veri de ki kiralanma tarihinden daha gec ise
        //O zaman zaten arac kiralanamaz cunku onun istedigi tarihte arac halen gelmemis olacak!!

      

        

        public IResult Delete(Rental rental)
        {
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalsListed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id==rentalId),Messages.RentalListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailDtos()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetailDtos(),
                Messages.RentalDetailDtoListed);
        }

        public IResult Update(Rental rental)
        {
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
