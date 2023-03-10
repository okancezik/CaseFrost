using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IEntityBaseDal<T> where T : class , IEntity , new()
    {
        void Add(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetByID(int id);
    }
}
