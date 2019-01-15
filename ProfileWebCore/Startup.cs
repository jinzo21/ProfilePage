using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProfileWebCore.Data;
using ProfileWebCore.Models;
using ProfileWebCore.Services;

namespace ProfileWebCore
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// Allows for changes in versions
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			// Inject our Pokedex Context
			services.AddDbContext<PokedexContext>(o => o.UseSqlServer(Configuration.GetConnectionString("localDb")));
			
			// Register our Repository: transient (created each time requested), scope(once per request), singleton(created first time)
			services.AddScoped<IPokedexRepository, PokedexRespority>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				// On by default: allows the ability to force the browser to only exists over https
				app.UseHsts();
			}

			// Set our Automapper for Entites to Dtos
			AutoMapper.Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<PokemonEntity, PokemonModel>();
				cfg.CreateMap<PokemonInsertModel, PokemonEntity>();
			});

			// Handles bouncing http request to the hsts
			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}
