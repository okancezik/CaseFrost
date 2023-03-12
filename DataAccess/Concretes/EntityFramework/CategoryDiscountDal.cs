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
    public class CategoryDiscountDal : ICategoryDiscountDal
    {
        public void Add(CategoryDiscount entity)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                dbContext.Set<CategoryDiscount>().Add(entity);
                dbContext.SaveChanges();
            }
        }

        public bool Delete(int id)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                var result = this.Get(cd => cd.CategoryDiscountID == id);
                if (result != null)
                {
                    dbContext.Set<CategoryDiscount>().Remove(result);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public CategoryDiscount? Get(Expression<Func<CategoryDiscount, bool>> filter)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<CategoryDiscount>().FirstOrDefault(filter);
            }
        }

        public List<CategoryDiscount> GetAll()
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<CategoryDiscount>().ToList();
            }
        }

        public List<CategoryDiscount> GetAll(Expression<Func<CategoryDiscount, bool>> filter = null)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                return filter == null ? dbContext.Set<CategoryDiscount>().ToList() : dbContext.Set<CategoryDiscount>().Where(filter).ToList();
            }
        }

        
    }
}
