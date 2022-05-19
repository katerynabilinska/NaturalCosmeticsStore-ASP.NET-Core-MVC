using Microsoft.AspNetCore.Mvc;

namespace NaturalCosmeticsStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}