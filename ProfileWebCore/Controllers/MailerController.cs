using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProfileWebCore.Models;
using ProfileWebCore.Services;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace ProfileWebCore.Controllers
{
	[Route("profile/sendMail")]
    [ApiController]
    public class MailerController : ControllerBase
    {
		private readonly IMailerService _mailerService;

		public MailerController(IMailerService mailerService)
		{
			_mailerService = mailerService;
		}

		[HttpPost()]
		public async Task<IActionResult> SendEmail([FromBody] MailInsert mail)
		{
			// Validate data
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			// Send email
			await _mailerService.SendMessage(mail.Email, mail.Message, mail.Name);
			return Ok("Email was sent.");
		}
	}
}