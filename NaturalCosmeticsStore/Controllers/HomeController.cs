using Microsoft.AspNetCore.Mvc;
using NaturalCosmeticsStore.Models;

namespace NaturalCosmeticsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
            => this.productRepository = productRepository;

        public IActionResult Index() => View();

        public ViewResult Products() => View(productRepository.Products);

        public ViewResult Edit(int productId) =>
            View(productRepository.Products.FirstOrDefault(
                p => p.Id == productId));

        [HttpPost] 
        public IActionResult Edit(Product product)
        {
            productRepository.SaveProduct(product);
            return RedirectToAction("Products");
        }

        public ViewResult Create()
        {
            return View("Edit", new Product());
        }

        [HttpPost]
        public IActionResult Delete(int productId)
        {
            productRepository.DeleteProduct(productId);
            return RedirectToAction("Products");
        }
    }
}