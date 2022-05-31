using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace NaturalCosmeticsStore.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(string userName, string userEmail, 
            string userMessage)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("katriiin132@gmail.com"));
            email.To.Add(MailboxAddress.Parse("katriiin132@gmail.com"));
            email.Subject = "New Message From NaturalCosmeticsStore";
            email.Body = new TextPart(TextFormat.Plain)
            {
                Text = $"User Name: {userName}\nUserEmail: {userEmail}\n" +
                $"User Message: {userMessage}"
            };

            var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("katriiin132@gmail.com", "cxzfnahrtbshrmdi");
            smtp.Send(email);
            smtp.Disconnect(true);

            return View("Thanks");
        }
    }
}
