using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                dbContext.Set<Product>().Add(entity);
                dbContext.SaveChanges();
            }
        }

        public bool Delete(int id)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                var result = this.Get(p => p.ProductID == id);
                if(result != null)
                {
                    dbContext.Set<Product>().Remove(result);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public Product? Get(Expression<Func<Product, bool>> filter)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<Product>().FirstOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return filter == null ? dbContext.Set<Product>().ToList() :
                    dbContext.Set<Product>().Where(filter).ToList();
            }
        }
    }
}
