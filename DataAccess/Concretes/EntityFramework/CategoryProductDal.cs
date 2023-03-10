using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Delete(int id)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                var result = this.GetByID(id);
                dbContext.Set<CategoryProduct>().Remove(result);
            }
        }

        public List<CategoryProduct> GetAll()
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<CategoryProduct>().ToList();
            }
        }

        public CategoryProduct GetByID(int id)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<CategoryProduct>().First(cp => cp.CategoryID == id);
            }
        }
    }
}
