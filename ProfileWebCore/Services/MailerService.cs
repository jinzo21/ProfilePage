using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace ProfileWebCore.Services
{
	public class MailerService : IMailerService
	{
		private readonly IConfigurationRepository _configurationRepository;

		public MailerService(IConfigurationRepository configurationRepository)
		{
			_configurationRepository = configurationRepository;
		}

		public async Task SendMessage(string email, string message, string name)
		{
			var apiKey = _configurationRepository.GetAccessKey("SendGrid");
			var client = new SendGridClient(apiKey.AccessValue);
			var from = new EmailAddress(email, name);
			List<EmailAddress> to = new List<EmailAddress>
			{
			  new EmailAddress("albertojurbina@gmail.com", "Profile Page"),
			};

			var subject = "Profile Site Message";
			var htmlContent = message;
			var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, to, subject, message, htmlContent, false);
			var response = await client.SendEmailAsync(msg);
		}
	}
}
