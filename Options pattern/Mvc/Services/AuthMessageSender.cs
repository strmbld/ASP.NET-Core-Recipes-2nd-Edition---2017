using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Mvc.Services
{
    public class AuthMessageSender : IEmailSender
    {
        private EmailSenderOptions options;


        public AuthMessageSender(IOptions<EmailSenderOptions> options)
        {
            options = (IOptions<EmailSenderOptions>)options.Value;
        }


        public async Task SendEmailAsync(string email, string subject, string message)
        {
            MimeMessage emailMessage = new();
            emailMessage.From.Add(new MailboxAddress(options.FromMailBoxName, options.FromMailBoxAddress));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };

            using (SmtpClient client = new())
            {
                client.LocalDomain = options.LocalDomain;
                await client
                    .ConnectAsync(options.EmailServer, options.EmailServerPort, SecureSocketOptions.StartTls)
                    .ConfigureAwait(false);
                await client
                    .AuthenticateAsync(options.Authentication.EmailUserName, options.Authentication.EmailPassword);
                await client.SendAsync(emailMessage).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }
        }

        public Task SendSmsAsync(string number, string message)
        {
            return Task.FromResult(0);
        }
    }
}
