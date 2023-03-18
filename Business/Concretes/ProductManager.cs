using Business.Abstracts;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofacs.Validation;
using Core.CrossCuttingConcerns.Validation;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Concretes.DTOs;
using FluentValidation;
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

        [ValidationAspect(typeof(ProductValidator))]
        public void Add(Product product)
        {

            //ValidationTool.Validate(new ProductValidator(),product);
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
