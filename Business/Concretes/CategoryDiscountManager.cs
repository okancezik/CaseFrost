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
    public class CategoryDiscountManager : ICategoryDiscountService
    {

        private ICategoryDiscountDal _categoryDiscountDal;

        public CategoryDiscountManager(ICategoryDiscountDal categoryDiscountDal)
        {
            _categoryDiscountDal= categoryDiscountDal;
        }

        public void Add(CategoryDiscount categoryDiscount)
        {
            _categoryDiscountDal.Add(categoryDiscount);
        }

        public bool Delete(int id)
        {
            return _categoryDiscountDal.Delete(id);
        }

        public List<CategoryDiscount> GetAll()
        {
            return _categoryDiscountDal.GetAll();
        }

        public CategoryDiscount? GetById(int id)
        {
            return _categoryDiscountDal.GetByID(id);
        }

        public CategoryDiscount? GetByName(string name)
        {
            return _categoryDiscountDal.GetByName(name);
        }
    }
}
