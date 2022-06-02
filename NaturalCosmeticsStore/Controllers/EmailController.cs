using Microsoft.AspNetCore.Mvc;
using NaturalCosmeticsStore.Models;

namespace NaturalCosmeticsStore.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailSender emailSender;
        public EmailController(IEmailSender emailSender) 
            => this.emailSender = emailSender;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(string userName, string userEmail, string userMessage)
        {
            emailSender.SendEmail(userName, userEmail, userMessage);
            return View("Thanks");
        }
    }
}
