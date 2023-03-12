using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost(Name ="AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            _productService.Add(product);
            return Ok();
        }

        [HttpDelete(Name ="DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            var result = _productService.Delete(id);
            return result == true ? Ok() : NotFound();
        }

        [HttpGet(Name ="GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            var result = _productService.GetAll();
            return Ok(result);
        }

        [HttpGet(Name ="GetByID")]
        public IActionResult GetByID(int id)
        {
            var result = _productService.GetById(id);
            return result != null ? Ok(result) : NotFound(); 
        }

        [HttpGet(Name ="GetByName")]
        public IActionResult GetByName(string name) 
        {
            var result = _productService.GetByName(name);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet(Name ="GetAllProductsDetails")]
        public IActionResult GetAllProductsDetails()
        {
            var result = _productService.GetAllDetails();
            return Ok(result);
        }
    }
}
