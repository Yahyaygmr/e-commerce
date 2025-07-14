using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok("Ürünler getirildi");
    }
    [HttpGet("{id}")]
     public IActionResult GetProduct(int id)
    {
        return Ok("Ürün Getirildi");
    }
}