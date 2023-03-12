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
    public interface IDiscountDal : IEntityBaseDal<Discount>
    {
        bool UpdateDiscountStateTurnOn(int id);
        bool UpdateDiscountStateTurnOff(int id);
        List<DiscountDetailsDTO> GetAllDiscountDetails(Expression<Func<DiscountDetailsDTO,bool>> filter = null);
    }
}
