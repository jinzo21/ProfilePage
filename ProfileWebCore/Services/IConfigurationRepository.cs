using ProfileWebCore.Data;
using ProfileWebCore.Models;

namespace ProfileWebCore.Services
{
	public interface IConfigurationRepository
	{
		ConfigurationModel GetAccessKey(string accessKey);
		void InsertConfiguration(ConfigurationEntity configurationEntity);
		bool Save();
	}
}