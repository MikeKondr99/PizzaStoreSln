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
        public async Task<IActionResult> ShoppingCart()
        {
            return View("Cart");
        }
    }
}