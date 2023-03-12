using Entities.Concretes;
using Entities.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        void Add(Product product);
        bool Delete(int id);
        List<Product> GetAll();
        Product? GetById(int id);
        Product? GetByName(string name);
        List<ProductDetailsDTO> GetAllDetails();
    }
}
