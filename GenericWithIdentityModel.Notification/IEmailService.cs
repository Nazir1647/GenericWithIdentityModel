using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithIdentityModel.Notification
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body, EmailPriority priority = EmailPriority.Normal, string attachmentURL = "", string name = "");
    }
}
