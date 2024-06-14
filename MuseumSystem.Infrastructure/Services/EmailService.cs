using MailKit.Net.Smtp;
using MimeKit;
using MuseumSystem.Application.ServiceContracts;

namespace MuseumSystem.Infrastructure.Services
{
    public class EmailService : IEmailService
    {

        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUser;
        private readonly string _smtpPass;
        private readonly string _smtpName;

        public EmailService(string smtpServer, int smtpPort, string smtpLogin, string smtpPas, string smtpName)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _smtpUser = smtpLogin;
            _smtpPass = smtpPas;
            _smtpName = smtpName;
        }

        public async Task SendAsync(string toEmail, string message, string subject)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_smtpName, _smtpUser));
            emailMessage.To.Add(new MailboxAddress("", toEmail));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };

            using var client = new SmtpClient();
            await client.ConnectAsync(_smtpServer, _smtpPort, true);
            await client.AuthenticateAsync(_smtpUser, _smtpPass);
            await client.SendAsync(emailMessage);
            await client.DisconnectAsync(true);
        }
    }
}
