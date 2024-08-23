using MailKit.Net.Smtp;
using MimeKit;

namespace BlazorContactForm.Services
{
    public class EmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("NoReply", "noreply@example.com"));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.example.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("your_email@example.com", "your_password");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
