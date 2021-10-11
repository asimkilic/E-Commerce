﻿using ApplicationLayer.Entities.Abstract;
using ApplicationLayer.Entities.Concrete;
using DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        // interface'ler metodların imzalarının yazıldığı yer
      
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}

