using carShop.Models;

namespace carShop.Repositories
{
    public class FakeCarRepository : ICarRepository
    {
        private readonly ICollection<Car> cars = new List<Car>()
        {
            new (1, "Bugatti", "Chiron", 2000000, "chiron.jpg", 1600),
            new (2, "Koenigsegg", "Regera", 1900000, "reggera.jpg", 1500),
            new (3, "Lamborghini", "Huracan", 400000, "huracan.jpg", 572),
            new (4, "Volkswagen", "Passat", 2000, "passat.jpg", 105)
        };

        public int Create(Car car)
        {
            cars.Add(car);
            return car.Id;
        }

        public bool Delete(int id)
        {
            var carToDelete = cars.First(x => x.Id == id);
            
            if (carToDelete is null)
            {
                return false;
            }

            cars.Remove(carToDelete);
            return true;
        }

        public IEnumerable<Car> GetAll()
        {
            return cars.ToList();
        }

        public Car GetCar(int id)
        {
            return cars.FirstOrDefault(Car => Car.Id == id);
        }

        public bool Update(int id, Car car)
        {
            var carToUpdate = cars.FirstOrDefault(x => x.Id == id);

            if (carToUpdate is null)
            {
                return false;
            }

            carToUpdate.Brand = car.Brand;
            carToUpdate.Model = car.Model;
            carToUpdate.Image = car.Image;
            carToUpdate.Price = car.Price;
            carToUpdate.Power = car.Power;

            return true;
        }
    }
}
