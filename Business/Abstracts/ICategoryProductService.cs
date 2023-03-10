using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryProductService
    {
        void Add(CategoryProduct categoryProduct);
        void Delete(int id);
        List<CategoryProduct> GetAll();
        CategoryProduct GetById(int id);
    }
}
