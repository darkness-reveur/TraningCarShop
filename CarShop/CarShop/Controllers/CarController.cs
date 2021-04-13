using CarShop.Common.Models;
using CarShop.Infrastructure.SomeLogic.Interfacies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService service)
        {
            _carService = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            return Ok(_carService.GetAllCars());
        }

        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id)
        {
            return _carService.GetCarById(id);
        }

        [HttpPost]
        public IActionResult Post(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.AddCar(car);

                return Ok(car);
            }

            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.UpdateCar(car);

                return Ok(car);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete]
        public IActionResult Delete(Car car)
        {
            _carService.DeleteCar(car);

            return Ok(car);
        }
    }
}
