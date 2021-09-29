using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.SuccesMessage);
        }
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.SuccesMessage);

        }
        public IResult Update(Brand brand)
        {
            if (DateTime.Now.Hour == 03)
            {
                return new ErrorResult(Messages.ErrorMessage);
            }
            _brandDal.Update(brand);
            return new SuccessResult(Messages.SuccesMessage);
        }
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>( _brandDal.GetAll());
        }
        public IDataResult<List<Brand>> GetByBrandId(int Id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(x => x.BrandId == Id));
        }
      
    }
}
