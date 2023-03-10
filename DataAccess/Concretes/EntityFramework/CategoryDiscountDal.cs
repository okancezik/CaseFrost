using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
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
            using(MyDbContext dbContext = new MyDbContext())
            {
                var result = this.GetByID(id);
                if (result != null)
                {
                    dbContext.Set<CategoryDiscount>().Remove(result);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public List<CategoryDiscount> GetAll()
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<CategoryDiscount>().ToList();
            }
        }

        public CategoryDiscount? GetByID(int id)
        {
           using(MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<CategoryDiscount>().FirstOrDefault(cd => cd.CategoryDiscountID == id);
            }
        }

        public CategoryDiscount? GetByName(string name)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<CategoryDiscount>().FirstOrDefault(cd => cd.CategoryName == name);
            }
        }
    }
}
