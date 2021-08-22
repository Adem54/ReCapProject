using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepostoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from r in context.Rentals
                             join car in context.Cars
                             on r.CarId equals car.CarId
                             join cus in context.Customers
                             on r.CustomerId equals cus.CustomerId
                             //where, select
                             select new RentalDetailDto
                             {
                               RentalId=r.Id,
                               CarName=car.CarName,
                               CompanyName=cus.CompanyName,
                               RentDate=r.RentDate,
                               ReturnDate=r.ReturnDate

                             };
                return result.ToList();
                          
            }
        }
    }
}
