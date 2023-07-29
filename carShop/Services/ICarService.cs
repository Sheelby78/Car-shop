using carShop.Models;

namespace carShop.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetAll();
        Car? GetById(int id);
        int Create(Car car);
        bool Update(int id, Car car);
        bool Delete(int id);
    }
}
