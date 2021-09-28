using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            if (car.DailyPrice > 0 && car.CarName.Length > 2)
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
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(x => x.Id == id);
        }

        public List<CarDetailsDTO> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
