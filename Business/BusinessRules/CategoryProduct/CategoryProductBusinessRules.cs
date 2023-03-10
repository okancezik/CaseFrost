using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules.CategoryProduct
{
    public class CategoryProductBusinessRules
    {
        public static bool ExistCategoryProduct(string categoryName, ICategoryProductDal categoryProductDal)
        {
            return categoryProductDal.ExistProductCategory(categoryName);

        }
    }
}
