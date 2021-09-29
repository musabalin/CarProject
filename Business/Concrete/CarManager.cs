using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public IResult Add(Car car)
        {
            if (car.CarName.Length > 2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.SuccesMessage);
            }
            else
            {
                return new ErrorResult(Messages.ErrorMessage);
            }



        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.SuccesMessage);
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.SuccesMessage);
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.SuccesMessage);
        }
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(x => x.Id == id));
        }

        public IDataResult<List<CarDetailsDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDTO>>(_carDal.GetCarDetails());
        }
    }
}
