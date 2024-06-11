using BestBuyCRUDApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BestBuyCRUDApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _repo;

        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var products = _repo.GetAllProducts();
            return View(products);
        }
    }
}
