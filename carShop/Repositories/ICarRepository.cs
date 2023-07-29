using carShop.Models;

namespace carShop.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();
        Car? GetCar(int id);
        int Create(Car car);
        bool Update(int id, Car car);
        bool Delete(int id);
    }
}
