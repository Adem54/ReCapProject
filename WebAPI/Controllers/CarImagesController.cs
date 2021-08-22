using Business.Abstract;
using Core.Utilities.Helpers.FileHelper;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
       
       // IFileHelper _fileHelper;
        ICarImageService _carImageService;

        public CarImagesController( ICarImageService carImageService)//IFileHelper fileHelper,
        {
           // _fileHelper = fileHelper;
            _carImageService = carImageService;
        }
        [HttpPost("add")]
        //Key olarak CarImage entities in de Car tablosununun id sini nasıl tuttuysanız onu yazın.mesela
        //ben CarId diye tuttum.key olarak CarId yazdım ve value da daha önce car tablosuna eklediğiniz 
        //var olan id ler den birini yazın.
        //2.Key olarak da ben image olarak yazdım.
        //çünkü benim CarImagesController ım şu şekilde:
        // public IActionResult Add([FromForm(Name = "Image")] IFormFile file, [FromForm] CarImage carImage)
        public IActionResult Add([FromForm(Name =("Image"))] IFormFile file, [FromForm] CarImage carImage)
        {
            //carImage burda 1 oluyor, CarImageManager da hep 0 di
            var result = _carImageService.Add(file, carImage);

            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int id)
        {
            var carImage = _carImageService.Get(id).Data;
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update([FromForm(Name =("Image"))] IFormFile file, 
            [FromForm(Name = ("Id"))] int id)//Kullanici postman de verileri girerken ornegin resmi 
            //yukerken Image anahtar kelimesini kullansin, guncellenecek image in id sini Id anahtar 
            //kelimesini kullanarak gondersin ve CarId bizim CarImage entity nesnesinde nasilsa o sekilde
            //girilir
        {
            var carImage = _carImageService.Get(id).Data;
            var result = _carImageService.Update(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getimagesbycarid")]
        public IActionResult GetImagesByCarId(int carId)
        {
            var result = _carImageService.GetImagesByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallimages")]
        public IActionResult GetAllImages()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
