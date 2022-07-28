using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatikaDev.Bussines.Abstract;
using PatikaDev.DTO.Customer;

namespace PatikaDev.ECommerceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomersController(ICustomerService service)
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
        public IActionResult Post(CustomerRequest customer)
        {
            var response = _service.Insert(customer);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(CustomerRequest customer)
        {
            var response = _service.Update(customer);
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

