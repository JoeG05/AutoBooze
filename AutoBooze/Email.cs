using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace AutoBooze
{
    class Email
    {

        public void sendMail(string fromAddress, string password, string toAddress, string subject, string body, string attachmentLocation)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(fromAddress);
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;

            Attachment attachment = new Attachment(@attachmentLocation);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential(fromAddress, password);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

    }
}
