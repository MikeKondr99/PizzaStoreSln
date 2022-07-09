using Microsoft.AspNetCore.Mvc;
using PizzaStore.Models;

namespace PizzaStore.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult SayHello()
        {
            return View("StringView", new StringModel("Hello Tomek!"));
        }

        [HttpGet("kawabanga")]
        public IActionResult GetPizzas()
        {
            return View("Pizzas", new List<Pizza>()
            {
                new Pizza("Маргарита"),
                new Pizza("Пеперони"),
                new Pizza("Мясная"),
            });
        }


    }
}
