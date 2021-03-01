using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car { Id=1 ,BrandId=1, ColorId=1, ModelYear =2015, DailyPrice= 1500, description= "Renault" },
                new Car { Id=2 ,BrandId=2, ColorId=2, ModelYear =2016, DailyPrice= 1600, description= "Skoda" },
                new Car { Id=3 ,BrandId=3, ColorId=3, ModelYear =2017, DailyPrice= 1700, description= "Volkswagen" },
                new Car { Id=4 ,BrandId=4, ColorId=4, ModelYear =2018, DailyPrice= 1800, description= "Mercedes" },
                new Car { Id=5 ,BrandId=5, ColorId=5, ModelYear =2019, DailyPrice= 1900, description= "Bmv" },

            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(Car car)
        {
            return _car.Where(c => c.Id == car.Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.description = car.description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
