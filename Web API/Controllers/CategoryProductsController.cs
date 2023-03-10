using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryProductsController : ControllerBase
    {
        private ICategoryProductService _categoryProductService;

        public CategoryProductsController(ICategoryProductService categoryProductService)
        {
            _categoryProductService = categoryProductService;
        }

        [HttpGet(Name = "GetAllCategoryProduct")]
        public IActionResult GetAllCategoryProduct()
        {
            var result = _categoryProductService.GetAll();
            return result != null ? Ok(result) : BadRequest("Products not found");
        }

        [HttpGet(Name = "GetByCategoryProductID")]
        public IActionResult GetByCategoryProductID(int id)
        {
            var result = _categoryProductService.GetById(id);
            return result != null ? Ok(result) : BadRequest("Product not found");
        }

        [HttpPost(Name = "AddCategoryProduct")]
        public IActionResult AddCategoryProduct(CategoryProduct categoryProduct)
        {
            _categoryProductService.Add(categoryProduct);
            return Ok();
        }

        [HttpDelete(Name = "DeleteCategoryProduct")]
        public IActionResult DeleteCategoryProduct(int id)
        {
            var result = _categoryProductService.Delete(id);
            return result == true ? Ok("Product was deleted") : BadRequest("Product not found");
        }

        [HttpGet(Name = "GetByNameCategoryProduct")]
        public IActionResult GetByNameCategoryProduct(string categoryName)
        {
            var result = _categoryProductService.GetByName(categoryName);
            return result != null ? Ok(result) : BadRequest();
        }
    }
}
