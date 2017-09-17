using System.Diagnostics;

namespace CityApi.Services
{
    public class MailService : IMailService
    {
        private string _fromAddress = Startup.Configuration["mailSettings:mailFromAddress"];
        private string _toAddress = Startup.Configuration["mailSettings:mailToAddress"];

        public void Send(string subject, string message)
        {
            Debug.WriteLine($"Mail from {_fromAddress} to {_toAddress}");
        }
    }
}