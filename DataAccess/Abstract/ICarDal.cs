using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarDal:IEntityRepostory<Car>
    {
        List<CarDetailDto> GetDetailDtos();

       
    }
}

//InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.