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
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>20)
            {
                _carDal.Add(car);

            }
            else
            {
                Console.WriteLine("Arabanın günlük ücreti 0'dan büyük olmalıdır.");
            }

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
