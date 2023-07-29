using carShop.Models;
using carShop.Repositories;

namespace carShop.Services
{
    public class CarServices : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarServices(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public int Create(Car car)
        {
            var id = _carRepository.Create(car);

            return id;
        }

        public bool Delete(int id)
        {
            var result = _carRepository.Delete(id);

            return result;
        }

        public IEnumerable<Car> GetAll()
        {
            var allCars = _carRepository.GetAll();

            var carsToReturn = allCars
                .Where(x => x.Price > 0)
                .ToList();

            return carsToReturn;
        }

        public Car? GetById(int id)
        {
            var result = _carRepository.GetCar(id);

            return result;
        }

        public bool Update(int id, Car car)
        {
            var result = _carRepository.Update(id, car);

            return result;
        }
    }
}
