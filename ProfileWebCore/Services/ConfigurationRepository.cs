using AutoMapper;
using ProfileWebCore.Data;
using ProfileWebCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileWebCore.Services
{
	public class ConfigurationRepository : IConfigurationRepository
	{
		private readonly ProfileContext _profileContext;

		public ConfigurationRepository(ProfileContext profileContext)
		{
			_profileContext = profileContext;
		}

		public ConfigurationModel GetAccessKey(string accessKey)
		{
			var configurationEntity = _profileContext.Configuration.Where(c => c.AccessKey == accessKey).FirstOrDefault();
			var results = Mapper.Map<ConfigurationModel>(configurationEntity);

			return results;

		}

		public void InsertConfiguration(ConfigurationEntity configurationEntity)
		{
			_profileContext.Add(configurationEntity);
		}

		/// <summary>
		/// Returns bool if there was an item changed
		/// </summary>
		/// <returns>Bool</returns>
		public bool Save()
		{
			return (_profileContext.SaveChanges() >= 0);
		}
	}
}
