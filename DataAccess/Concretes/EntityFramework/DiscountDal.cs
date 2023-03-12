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
    public class DiscountDal : IDiscountDal
    {
        public void Add(Discount entity)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                dbContext.Set<Discount>().Add(entity);
                dbContext.SaveChanges();
            }
        }

        public bool Delete(int id)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                var result = this.Get(d => d.DiscountID == id);
                if(result != null)
                {
                    dbContext.Set<Discount>().Remove(result);
                    dbContext.SaveChanges() ;
                    return true;
                }
                return false;
            }
        }

        public Discount? Get(Expression<Func<Discount, bool>> filter)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Set<Discount>().FirstOrDefault(filter); 
            }
        }

        public List<Discount> GetAll(Expression<Func<Discount, bool>> filter = null)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return filter == null ? dbContext.Set<Discount>().ToList() : 
                    dbContext.Set<Discount>().Where(filter).ToList();  
            }
        }

        public bool UpdateDiscountStateTurnOn(int id)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                var result = this.Get(d => d.CategoryID == id);
                if (result != null)
                {
                    result.DiscountState = true;
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool UpdateDiscountStateTurnOff(int id)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                var result = this.Get(d => d.CategoryID == id);
                if (result != null)
                {
                    result.DiscountState = false;
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
