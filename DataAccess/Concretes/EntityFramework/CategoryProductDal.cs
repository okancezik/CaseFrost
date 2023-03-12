using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class CategoryProductDal : ICategoryProductDal
    {
        public void Add(CategoryProduct entity)
        {
            using(MyDbContext dbContext = new MyDbContext()) 
            {
                dbContext.Set<CategoryProduct>().Add(entity);
                dbContext.SaveChanges();
            }
        }

        public bool Delete(int id)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                var result = this.Get(cp => cp.CategoryProductID == id);
                if(result != null)
                {
                    dbContext.Set<CategoryProduct>().Remove(result);
                    dbContext.SaveChanges() ;
                    return true;
                }
                return false;
            }
        }

        public bool ExistProductCategory(string categoryName)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                var result = dbContext.Set<CategoryProduct>().FirstOrDefault(cp => cp.CategoryName == categoryName);
                return result == null ? false : true;
            }
        }

        public CategoryProduct? Get(Expression<Func<CategoryProduct, bool>> filter)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<CategoryProduct>().FirstOrDefault(filter);
            }
        }

        public List<CategoryProduct> GetAll(Expression<Func<CategoryProduct, bool>> filter = null)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return filter == null ? dbContext.Set<CategoryProduct>().ToList()
                    : dbContext.Set<CategoryProduct>().Where(filter).ToList();

            }
        }
    }
}
