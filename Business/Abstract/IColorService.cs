﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        public List<Color> GetAll();
        public List<Color> GetById(int id);
        public void Add(Color color);
        public void Delete(Color color);
        public void Update(Color color);

    }
}
