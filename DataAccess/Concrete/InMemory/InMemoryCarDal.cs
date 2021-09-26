using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
          {
              new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150000,Description="Yürüyeni iyi",ModelYear="2017"},
              new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=100000,Description="Kazalı Araç",ModelYear="2011"},
              new Car{Id=3,BrandId=3,ColorId=1,DailyPrice=140000,Description="Tramer Yok",ModelYear="2015"},
              new Car{Id=4,BrandId=2,ColorId=1,DailyPrice=175000,Description="Fabrikadan çıktığı gibi",ModelYear="2018"},
          };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var result = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(result);
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

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            var result = _cars.SingleOrDefault(c => c.Id == car.Id);
            result.BrandId = car.BrandId;
            result.Description = car.Description;
            result.DailyPrice = car.DailyPrice;
            result.ColorId = car.ColorId;
            result.ModelYear = car.ModelYear;
        }
    }
}
