using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetById(int id);
        public IResult Add(Color color);
        public IResult Delete(Color color);
        public IResult Update(Color color);

    }
}
