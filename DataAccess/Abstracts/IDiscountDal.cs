using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IDiscountDal : IEntityBaseDal<Discount>
    {
        bool UpdateDiscountStateTurnOn(int id);
        bool UpdateDiscountStateTurnOff(int id);
    }
}
