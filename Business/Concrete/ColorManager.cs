using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("eklendi");
        }
        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }
        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Güncellendi..");
        }

        public List<Color> GetById(int id)
        {
            return _colorDal.GetAll(c => c.ColorId == id);
        }
    }
}
