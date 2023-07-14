using Asp.NetMvcApp.Data;
using Asp.NetMvcApp.Interfaces;
using Asp.NetMvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.NetMvcApp.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContext _dbContext;
        public CarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Car> Cars => _dbContext.Cars.Include(x => x.Category);

        public IEnumerable<Car> getFavCars => _dbContext.Cars.Where(x => x.isFavourite).Include(x => x.Category);

        public Car getObjectCar(int carId)
        {
            return _dbContext.Cars.FirstOrDefault(x => x.Id == carId);
        }
    }
}
