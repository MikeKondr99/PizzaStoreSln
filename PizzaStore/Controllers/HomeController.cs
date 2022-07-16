using Microsoft.AspNetCore.Mvc;
using PizzaStore.Services;

namespace PizzaStore.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {

        private IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetProducts()
        {
            return View("Products", await productService.GetProductsAsync());
        }

        [HttpGet("about")]
        public async Task<IActionResult> About()
        {
            return View("About");
        }

        [HttpGet("cart")]
        public async Task<IActionResult> ShoppingCart([FromQuery] string cart)
        {
            var prods = cart.Split(new char[] { ',' });
            var cart2 = prods.Select(x => {
                var pr = x.Split(':');
                return (productService.GetProductAsync(int.Parse(pr[0])).Result,int.Parse(pr[1]));
            });
            return View("Cart",cart2.ToList());
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return Ok(await productService.GetProductAsync(id));
        }
    }
}