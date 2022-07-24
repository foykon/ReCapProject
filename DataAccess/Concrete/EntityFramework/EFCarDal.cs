using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car, ReCapProjectDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectDatabaseContext context = new ReCapProjectDatabaseContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join c2 in context.Color
                             on c.ColorId equals c2.ColorId
                             select new CarDetailDto
                             {   CarId=c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName= c2.ColorName,
                                 DailyPrice=c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}

        
    
