using ContosoUniversity.Services;
using Microsoft.Extensions.Options;

namespace ContosoUniversity
{
    //internal class AuthMessageSender : IEmailSender : ISmsSender
    //{
    //    public AuthMessageSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
    //    {
    //        optionsAccessor = optionsAccessor.Value;
    //    }
    //}
    public class AuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
    }
}