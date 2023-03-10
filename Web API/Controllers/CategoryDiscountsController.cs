using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryDiscountsController : ControllerBase
    {
        private ICategoryDiscountService _discountService;

        public CategoryDiscountsController(ICategoryDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet(Name = "GetAllCategoryDiscount")]
        public IActionResult GetAllCategoryDiscount()
        {
            var result = _discountService.GetAll();
            return Ok(result);
        }

        [HttpGet(Name = "GetByCategoryDiscountID")]
        public IActionResult GetByCategoryDiscountID(int id)
        {
            var result = _discountService.GetById(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet(Name = "GetByCategoryDiscountName")]
        public IActionResult GetByCategoryDiscountName(string name)
        {
            var result = _discountService.GetByName(name);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost(Name = "AddCategoryDiscount")]
        public IActionResult AddCategoryDiscount(CategoryDiscount categoryDiscount)
        {
            _discountService.Add(categoryDiscount);
            return Ok();
        }

        [HttpDelete(Name = "DeleteCategoryDiscount" +
            "")]
        public IActionResult DeleteCategoryDiscount(int id) 
        {
            var result = _discountService.Delete(id);
            return result == true ? Ok() : NotFound();
        }
    }
}
