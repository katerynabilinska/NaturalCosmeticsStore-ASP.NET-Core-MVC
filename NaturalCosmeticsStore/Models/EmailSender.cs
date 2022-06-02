using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace NaturalCosmeticsStore.Models
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration configuration;
        public EmailSender(IConfiguration configuration)
            => this.configuration = configuration;

        public void SendEmail(string userName, string userEmail, string userMessage)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(configuration["Email"]));
            email.To.Add(MailboxAddress.Parse(configuration["Email"]));
            email.Subject = "New Message From NaturalCosmeticsStore Users";
            email.Body = new TextPart(TextFormat.Plain)
            {
                Text = $"User Name: {userName}\nUserEmail: {userEmail}\n" +
                $"User Message: {userMessage}"
            };

            var smtp = new SmtpClient();
            smtp.Connect(configuration["EmailSmtp"], 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(configuration["Email"], configuration["EmailPassword"]);
            smtp.Send(email);

            smtp.Disconnect(true);
        }
    }
}
