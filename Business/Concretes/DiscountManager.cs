using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class DiscountManager : IDiscountService
    {

        private IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }
        public void Add(Discount discount)
        {
            _discountDal.Add(discount);
        }

        public bool Delete(int id)
        {
            return _discountDal.Delete(id);
        }

        public List<Discount> GetAll()
        {
            return _discountDal.GetAll();
        }

        public List<Discount> GetAllCurrentDiscount()
        {
            return _discountDal.GetAll(d => d.DiscountState == true);
        }

        public List<DiscountDetailsDTO> GetAllDetails()
        {
            return _discountDal.GetAllDiscountDetails();
        }

        public Discount? GetById(int id)
        {
            return _discountDal.Get(d => d.DiscountID == id);
        }

        public Discount? GetByName(string name)
        {
            return _discountDal.Get(d => d.DiscountName == name);
        }

        public bool UpdateDiscountTurnOff(int id)
        {
            return _discountDal.UpdateDiscountStateTurnOn(id);
        }

        public bool UpdateDiscountTurnOn(int id)
        {
            return _discountDal.UpdateDiscountStateTurnOff(id);
        }
    }
}
