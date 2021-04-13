using CarShop.Common.Models;
using CarShop.Infrastructure.Databases;
using CarShop.Infrastructure.SomeLogic.Interfacies;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarShop.Infrastructure.SomeLogic.Implemented
{
    public class CarService : ICarService
    {
        private CarShopContext _dbContext;

        public CarService(CarShopContext shopContext)
        {
            _dbContext = shopContext;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _dbContext.Cars.Include(c => c.BrandModel)
                .ThenInclude(d => d.CarBrand).ToList();
        }

        public Car GetCarById(int id)
        {
            return _dbContext.Cars.Include(c => c.BrandModel)
                .ThenInclude(d => d.CarBrand)
                .FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Car> GetAllCarsOfSomeBrand(int brandId)
        {
            return _dbContext.Cars.Include(c => c.BrandModel)
                .ThenInclude(d => d.CarBrand)
                .Where(f => f.BrandModel.CarBrand.Id == brandId)
;
        }

        public IEnumerable<Car> GetAllCarsOfSomeMobel(int modelId)
        {
            return _dbContext.Cars.Include(c => c.BrandModel)
                .ThenInclude(d => d.CarBrand)
                .Where(f => f.BrandModel.Id == modelId);
        }

        public IEnumerable<Car> GetCarsByYearOfRelease(int earlyYear, int laterYear)
        {
            return _dbContext.Cars.Include(c => c.BrandModel)
                .ThenInclude(d => d.CarBrand)
                .Where(f => f.ReleaseYear <= laterYear && f.ReleaseYear >= earlyYear);
        }

        public IEnumerable<Car> GetCarsByPrice(int minPrice, int maxPrice)
        {
            return _dbContext.Cars
                .Include(c => c.BrandModel)
                    .ThenInclude(d => d.CarBrand)
                .Where(f => f.Price <= maxPrice && f.Price >= maxPrice);
        }

        public void AddCar(Car car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }

        public void UpdateCar(Car newCar)
        {
            Car car = _dbContext.Cars
                .FirstOrDefault(f => f.Id == newCar.Id);

            car.VehicleMileage = newCar.VehicleMileage;

            car.Price = newCar.Price;

            car.Description = newCar.Description;

            _dbContext.SaveChanges();
        }
        public void DeleteCar(Car car)
        {
            Car car1 = _dbContext.Cars
                .AsNoTracking()
                .FirstOrDefault(f => f.Id == car.Id);

            _dbContext.Remove(car1);

            _dbContext.SaveChanges();
        }

        public IEnumerable<BrandModel> GetAllCarModels()
        {
            return _dbContext.BrandModels;
        }

        public IEnumerable<CarBrand> GetAllCarBrands()
        {
            return _dbContext.CarBrands;
        }
    }
}
