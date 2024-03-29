﻿using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IEntityBaseDal<T> where T : class , IEntity , new()
    {
        void Add(T entity);
        bool Delete(int id);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T? Get(Expression<Func<T, bool>> filter);
    }
}
