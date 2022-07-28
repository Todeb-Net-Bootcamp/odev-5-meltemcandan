using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatikaDev.Bussines.Abstract;
using PatikaDev.DTO.Basket;

namespace PatikaDev.ECommerceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.GetAll();
            return Ok(data);
        }


        [HttpPost]
        public IActionResult Post(ProductRequest product)
        {
            var response = _service.Insert(product);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(ProductRequest product)
        {
            var response = _service.Update(product);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = _service.Delete(id);
            return Ok(response);
        }
    }
}
