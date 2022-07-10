using Microsoft.AspNetCore.Mvc;
using PizzaStore.Models;

namespace PizzaStore.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {

        [HttpGet("")]
        public async Task<IActionResult> GetProducts()
        {
            return View("Products", new List<Product>()
            {
                new Product("Маргарита",15,
                description: "Очень вкусная пицца итд",
                imageSourse:"https://s1.eda.ru/StaticContent/Photos/120131085053/171027192707/p_O.jpg",
                discount: 15
                ),
                new Product("Пеперони",16,outOfStock:true),
                new Product("Мясная",345),
                new Product("Маргарита",15,
                description: "Очень вкусная пицца итд",
                imageSourse:"https://s1.eda.ru/StaticContent/Photos/120131085053/171027192707/p_O.jpg",
                discount: 15
                ),
                new Product("Пеперони",16,outOfStock:true),
                new Product("Мясная",345),
            });
        }


    }
}
