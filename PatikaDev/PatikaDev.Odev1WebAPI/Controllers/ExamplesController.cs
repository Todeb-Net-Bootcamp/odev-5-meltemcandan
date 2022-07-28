using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PatikaDev.Odev1WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        /// <summary>
        /// Bu method dünyaya selam verir.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        ///  Bu method parametre olarak aldığı isim soyisme selam verir.
        /// </summary>
        /// <param name="name">Selam verilecek kişinin adı</param>
        /// <param name="surname">Selam verilecek kişinin soyadı</param>
        /// <returns></returns>
        [HttpPost]
        public string HelloPerson(string name, string surname)
        {
            return $"Hello {name} {surname}";
        }
    }

}

