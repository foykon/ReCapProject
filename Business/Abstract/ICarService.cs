using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetByBrandId(int BrandId);
        List<Car> GetByColorId(int ColorId);
        List<Car> GetAll();

    }
}
