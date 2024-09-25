using ASP.NET_Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_MVC.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepo _repo;

    public ProductController(IProductRepo repo)
    {
        _repo = repo;
    }
    // GET
    public IActionResult Index()
    {
        var products = _repo.GetAllProducts();
        return View(products);
    }
}