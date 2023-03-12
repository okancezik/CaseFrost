using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IDiscountService
    {
        void Add(Discount discount);
        bool Delete(int id);
        List<Discount> GetAll();
        List<Discount> GetAllCurrentDiscount();
        Discount? GetById(int id);
        Discount? GetByName(string name);
        bool UpdateDiscountTurnOn(int id);
        bool UpdateDiscountTurnOff(int id);

    }
}
