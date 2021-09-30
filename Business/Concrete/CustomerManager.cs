using Business.Abstract;
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
    public class CustomerManager : ICustomerService
    {
        ICustumerDal _customerDal;

        public CustomerManager(ICustumerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {

            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IResult Update(Customer customer)
        {

            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
