﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    class EFColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RentACarContext context=new RentACarContext())
            {
                var addColor = context.Entry(entity);
                addColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (RentACarContext context=new RentACarContext())
            {
                var deleteColor = context.Entry(entity);
                deleteColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RentACarContext context=new RentACarContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (RentACarContext context=new RentACarContext())
            {
                var updateColor = context.Entry(entity);
                updateColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
