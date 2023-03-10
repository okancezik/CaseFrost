using Business.Abstracts;
using Business.BusinessRules.CategoryProduct;
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
            _categoryProductDal.Add(categoryProduct);
        }

        public bool Delete(int id)
        {
            return _categoryProductDal.Delete(id);
        }

        public List<CategoryProduct> GetAll()
        {
            return _categoryProductDal.GetAll();
        }

        public CategoryProduct? GetById(int id)
        {
            return _categoryProductDal.GetByID(id);
        }

        public CategoryProduct? GetByName(string name)
        {
            return _categoryProductDal.GetByName(name);
        }
    }
}
