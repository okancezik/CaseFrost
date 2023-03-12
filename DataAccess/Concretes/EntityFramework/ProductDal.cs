using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.Concretes.DTOs;
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

        public List<ProductDetailsDTO> GetAllProductDetails(Expression<Func<ProductDetailsDTO, bool>> filter = null)
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                var result = from p in dbContext.Set<Product>()
                             join cp in dbContext.Set<CategoryProduct>()
                             on p.ProductCategoryID equals cp.CategoryProductID
                             join d in dbContext.Set<Discount>()
                             on p.DiscountID equals d.DiscountID
                             select new ProductDetailsDTO
                             {
                                 ProductName = p.ProductName,
                                 CategoryName = cp.CategoryName,
                                 DiscountName = d.DiscountName,
                                 DiscountState = d.DiscountState,
                                 DiscountStartDate = d.DiscountStartDate,
                                 DiscountEndDate = d.DiscountEndDate,
                                 UnitsInStock = p.UnitsInStock,
                                 UnitPrice = p.UnitPrice
                             };

                if(filter == null)
                {
                    return result.ToList();
                }
                return result.Where(filter).ToList() ;
            }
        }

 
    }
}
