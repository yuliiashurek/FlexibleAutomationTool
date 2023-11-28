using System.Net.Mail;
using System.Net;
using NotificationFactoryService.Printers;

namespace NotificationFactoryService.Senders
{
    public class EmailSender : ISender
    {
        private string _senderEmail;
        private string _senderPassword;
        private string _recepient;

        public EmailSender(string recepient = "juliysik@gmail.com", string email = "juliysik@outlook.com", string password = "kursova2023")
        {
            _senderEmail = email;
            _recepient = recepient;
            _senderPassword = password;
        }

        public void Send(IPrint printItem)
        {
            MailMessage mail = new MailMessage
            {
                From = new MailAddress(_senderEmail),
                Subject = "Subject of your email",
                Body = printItem.Print(),
                IsBodyHtml = true, // Set this to true if your email contains HTML content
            };

            mail.To.Add(new MailAddress(_recepient));

            SmtpClient smtpClient = new SmtpClient
            {
                Host = "smtp-mail.outlook.com",
                Port = 587, // Gmail SMTP port
                Credentials = new NetworkCredential(_senderEmail, _senderPassword),
                EnableSsl = true,
            };
            try {
                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully.");
                //return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                //return false;
            }
        }
    }
}
