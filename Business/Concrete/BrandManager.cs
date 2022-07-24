using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            bool IsBrandValid = false;
            foreach (var _color in _brandDal.GetAll())
            {
                if (_color.BrandId == brand.BrandId) { IsBrandValid = true; }
            }
            if (IsBrandValid)
            {
                _brandDal.Update(brand);
            }
            else
            {
                Console.WriteLine("No Valid Car");
            }
        }
    }
}
