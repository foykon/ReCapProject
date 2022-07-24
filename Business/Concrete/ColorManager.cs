using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c => c.ColorId == colorId);
        }

        public void Update(Color color)
        {
            bool IsColorValid = false;
            foreach (var _color in _colorDal.GetAll())
            {
                if (_color.ColorId == color.ColorId) { IsColorValid = true; }
            }
            if (IsColorValid)
            {
                _colorDal.Update(color);
            }
            else
            {
                Console.WriteLine("No Valid Car");
            }
        }
    }
}
