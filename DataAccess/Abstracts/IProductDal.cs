using Entities.Concretes;
using Entities.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IProductDal : IEntityBaseDal<Product>
    {
        List<ProductDetailsDTO> GetAllProductDetails(Expression<Func<ProductDetailsDTO,bool>> filter = null);
    }
}
