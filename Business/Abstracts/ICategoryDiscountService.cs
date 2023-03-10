using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryDiscountService
    {
        void Add(CategoryDiscount categoryDiscount);
        bool Delete(int id);
        List<CategoryDiscount> GetAll();
        CategoryDiscount? GetById(int id);
        CategoryDiscount? GetByName(string name);
    }
}
