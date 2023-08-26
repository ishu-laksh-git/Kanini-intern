using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pizzaAPI.Interfaces;
using pizzaAPI.Models;

namespace pizzaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IRepo<int, Pizza> _repo;
        public PizzaController(IRepo<int,Pizza> repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public ActionResult<Pizza> Post(Pizza pizza)
        {
            Pizza prod = _repo.Add(pizza);
            return Created("PizzaListing", prod);
        }
    }
}
