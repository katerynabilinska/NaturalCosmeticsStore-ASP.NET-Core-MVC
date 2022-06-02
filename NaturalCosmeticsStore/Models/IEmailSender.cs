namespace NaturalCosmeticsStore.Models
{
    public interface IEmailSender
    {
       void SendEmail(string userName, string userEmail, string userMessage);
    }
}
