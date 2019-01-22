using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProfileWebCore.Data;
using ProfileWebCore.Models;
using ProfileWebCore.Services;
using System.Collections.Generic;

namespace ProfileWebCore.Controllers
{
	[Route("profile/config")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
		private readonly IConfigurationRepository _configurationReposiroty;

		public ConfigurationController(IConfigurationRepository configurationRepository)
		{
			_configurationReposiroty = configurationRepository;
		}

		[HttpGet()]
		public IActionResult GetAccessValue(string accessValue)
		{
			var configurationEntity = _configurationReposiroty.GetAccessKey(accessValue);

			// Map from Entity list do Dto list
			var results = Mapper.Map<List<ConfigurationModel>>(configurationEntity);

			return Ok(results);
		}

		[HttpPost()]
		public IActionResult InsertConfiguration([FromBody] ConfigurationInsert configurationInsert)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var configuratioEntity = Mapper.Map<ConfigurationEntity>(configurationInsert);
			_configurationReposiroty.InsertConfiguration(configuratioEntity);

			if (!_configurationReposiroty.Save())
			{
				return StatusCode(500, "A problem happened while handling your request");
			}

			return StatusCode(201);
		}
	}
}