using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        public List<Brand> GetByBrandId(int Id);
        public void Add(Brand brand);
        public void Delete(Brand brand);
        public void Update(Brand brand);

    }
}

