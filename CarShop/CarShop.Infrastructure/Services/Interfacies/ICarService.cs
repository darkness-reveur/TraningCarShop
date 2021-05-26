using CarShop.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.Infrastructure.Services.Interfacies
{
    public interface ICarService
    {
        IEnumerable<Car> GetAllCars();

        Car GetCarById(int id);

        void AddCar(Car car);

        void UpdateCar(Car car);

        void DeleteCar(Car car);
    }
}
