using FlexibleAutomationTool.BL.AutomationTasks.Printers;
using FlexibleAutomationTool.BL.AutomationTasks.Senders;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;

namespace FlexibleAutomationTool.BL.Services
{
    public class EmailService : ISender
    {
        private ISender _sender;
        private string _senderEmail = "yourEmailAddress@gmail.com";
        private string _senderPassword = "yourPassword";
        public EmailService(ISender sender, string email, string password)
        {
            _sender = sender;
            _senderEmail = email;
            _senderPassword = password;
        }

        public void Send(IPrint printItem)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string emailRecepient)
        {
            MailMessage mail = new MailMessage
            {
                From = new MailAddress(_senderEmail),
                Subject = "Subject of your email",
                Body = "Body of your email",
                IsBodyHtml = true, // Set this to true if your email contains HTML content
            };

            mail.To.Add(new MailAddress(emailRecepient));

            // Specify the path to the file you want to attach
            string attachmentFilePath = "C:\\Path\\To\\Your\\File.txt";

            // Attach the file to the email
            Attachment attachment = new Attachment(attachmentFilePath, MediaTypeNames.Application.Octet);
            mail.Attachments.Add(attachment);

            SmtpClient smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587, // Gmail SMTP port
                Credentials = new NetworkCredential(_senderEmail, _senderPassword),
                EnableSsl = true,
            };

            try
            {
                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
    
    }
}
