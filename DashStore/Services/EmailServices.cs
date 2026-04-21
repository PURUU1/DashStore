using MailKit.Security;
using MimeKit;
using System.Net.Mail;
using MailKit.Net.Smtp;

using Microsoft.Extensions.Configuration;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
namespace DashStore.Services
{
    public class EmailServices
    {
        private readonly IConfiguration _config;
    public EmailServices(IConfiguration config) { _config = config; }

        public async Task SendEmailAsync(string toEmail, string subject, string htmlMessage)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(_config["EmailSettings:SenderName"], _config["EmailSettings:SenderEmail"]));
            email.To.Add(MailboxAddress.Parse(toEmail));
            email.Subject = subject;

            var builder = new BodyBuilder { HtmlBody = htmlMessage };
            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            try
            {
                // Connect to Gmail SMTP
                await smtp.ConnectAsync(_config["EmailSettings:SmtpServer"],
                                       int.Parse(_config["EmailSettings:Port"]),
                                       SecureSocketOptions.StartTls);

                // Authenticate using the App Password
                await smtp.AuthenticateAsync(_config["EmailSettings:SenderEmail"],
                                            _config["EmailSettings:AppPassword"]);

                await smtp.SendAsync(email);
            }
            finally
            {
                await smtp.DisconnectAsync(true);
            }
        }

    }
}
