using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private IDiscountService _discountService;
        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet(Name ="GetAllDiscount")]
        public IActionResult GetAllDiscount()
        {
            var result = _discountService.GetAll();
            return Ok(result);
        }

        [HttpGet(Name = "GetDiscountByID")]
        public IActionResult GetDiscountByID(int id)
        {
            var result = _discountService.GetById(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet(Name ="GetDiscountByName")]
        public IActionResult GetDiscountByName(string name)
        {
            var result = _discountService.GetByName(name);
            return result != null ? Ok(result) : NotFound();    
        }

        [HttpPost(Name ="AddDiscount")]
        public IActionResult AddDiscount(Discount discount)
        {
            _discountService.Add(discount);
            return Ok();
        }

        [HttpDelete(Name ="DeleteDiscount")]
        public IActionResult DeleteDiscount(int id)
        {
            var result = _discountService.Delete(id);
            return result == true ? Ok() : NotFound();
        }

        [HttpPut(Name ="UpdateDiscountTurnOn")]
        public IActionResult UpdateDiscountTurnOn(int id)
        {
            var result = _discountService.UpdateDiscountTurnOn(id);
            return result == true ? Ok() : NotFound();
        }

        [HttpPut(Name = "UpdateDiscountTurnOff")]
        public IActionResult UpdateDiscountTurnOff(int id)
        {
            var result = _discountService.UpdateDiscountTurnOff(id);
            return result == true ? Ok() : NotFound();
        }
    }
}
