using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryProductManager : ICategoryProductService
    {

        private ICategoryProductDal _categoryProductDal;

        public CategoryProductManager(ICategoryProductDal categoryProductDal)
        {
            _categoryProductDal = categoryProductDal;
        }

        public void Add(CategoryProduct categoryProduct)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryProduct GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
