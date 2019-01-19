using System.Threading.Tasks;

namespace ProfileWebCore.Services
{
	public interface IMailerService
	{
		Task SendMessage(string email, string message, string name);
	}
}