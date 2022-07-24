using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=200,Description="Reno Clio Beyaz 2015",ModelYear=2015},
            new Car{CarId=2,BrandId=1,ColorId=2,DailyPrice=400,Description="Reno Clio Siyah 2020",ModelYear=2020},
            new Car{CarId=3,BrandId=2,ColorId=1,DailyPrice=250,Description="Audi a4 Beyaz 2015",ModelYear=2015},
            new Car{CarId=4,BrandId=2,ColorId=2,DailyPrice=500,Description="Audi a4 Siyah 2020",ModelYear=2020}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public List<Car> GetByColorId(int ColorId)
        {
            return _cars.Where(c => c.ColorId == ColorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate;
            CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.BrandId=car.BrandId ;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
        }
    }
}
