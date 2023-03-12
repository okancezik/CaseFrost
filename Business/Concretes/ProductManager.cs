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
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public bool Delete(int id)
        {
            return _productDal.Delete(id); 
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<ProductDetailsDTO> GetAllDetails()
        {
            return _productDal.GetAllProductDetails();
        }

        public Product? GetById(int id)
        {
            return _productDal.Get(p => p.ProductID == id);  
        }

        public Product? GetByName(string name)
        {
            return _productDal.Get(p => p.ProductName == name);
        }
    }
}
