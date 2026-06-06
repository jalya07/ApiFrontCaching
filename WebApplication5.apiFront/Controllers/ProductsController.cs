using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.apiFront.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : Controller
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = new List<object>
        {
            new { Id = 1, Name = "iPhone" },
            new { Id = 2, Name = "Samsung" }
        };

        return Ok(products);
    }
}