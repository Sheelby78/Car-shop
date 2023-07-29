using carShop.Models;
using carShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace carShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetAllCars()
        {
            var cars = _carService.GetAll();

            return Ok(cars);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCarById(int id)
        {
            var car = _carService.GetById(id);

            if (car is null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        [HttpPost]
        public IActionResult CreateCar(Car car)
        {
            var id = _carService.Create(car);

            return Created($"/api/car/{id}", car);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateCar([FromRoute] int id, [FromBody] Car car)
        {
            var isSuccess = _carService.Update(id, car);

            if (!isSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCar(int id)
        {
            var isSuccess = _carService.Delete(id);

            if (!isSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
