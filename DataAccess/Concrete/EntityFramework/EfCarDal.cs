using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepostoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetDetailDtos()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.CarBrandId equals b.BrandId
                             join cl in context.Colors
                             on c.CarColorId equals cl.ColorId
                             //where,oderBy
                             select new CarDetailDto
                             {
                                 CarId = c.CarColorId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 CarDailyPrice = c.CarDailyPrice
                             };
                return result.ToList();

                           
            }
        }
    }
}

//Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. 
//    (İpucu : IDto oluşturup 3 tabloya join yazınız)