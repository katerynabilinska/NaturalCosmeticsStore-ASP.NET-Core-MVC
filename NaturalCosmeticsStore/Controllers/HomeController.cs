using Microsoft.AspNetCore.Mvc;
using NaturalCosmeticsStore.Models;

namespace NaturalCosmeticsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
            => this.productRepository = productRepository;
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Products()
        {
            return View(productRepository.Products);
        }
    }
}