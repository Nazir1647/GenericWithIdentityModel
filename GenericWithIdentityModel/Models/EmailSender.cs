using GenericWithIdentityModel.Notification;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace GenericWithIdentityModel.Models
{
    public class EmailSender : IEmailSender
    {
        public IEmailService _emailService;
        public EmailSender(IEmailService emailService) {

            _emailService = emailService;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            _emailService.SendEmail(email, subject, htmlMessage);
            return Task.CompletedTask;
        }
    }
}
