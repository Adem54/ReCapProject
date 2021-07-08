using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Car:IEntity
    {
        public int CarId { get; set; }
        public int CarBrandId { get; set; }
        public int CarColorId { get; set; }
        public int CarModelYear   { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}



//Bir araba nesnesi oluşturunuz. "Car"

//Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

//InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

//Consolda test ediniz.