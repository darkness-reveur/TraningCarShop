using CarShop.Common.Models;
using CarShop.Infrastructure.Services.Interfacies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
            return Ok(_carService.GetAllCars());
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetById(int id)
        {
            return _carService.GetCarById(id);
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.AddCar(car);

                return Ok(car);
            }

            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult UpdateCarInfo(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.UpdateCar(car);

                return Ok(car);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete]
        public IActionResult DeleteCar(Car car)
        {
            _carService.DeleteCar(car);

            return Ok(car);
        }
    }
}
