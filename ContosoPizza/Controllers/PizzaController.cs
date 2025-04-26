using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        [HttpGet()]
        public ActionResult<List<Pizza>> index() => PizzaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Pizza?> Get(int id)
        {
            var pizza = PizzaService.Get(id);
            if (pizza == null)
                return NotFound();

            return pizza;
        }
    }
}
