using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
			services.AddCors();
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			// We add our config file as a singleton
			services.AddSingleton(Configuration);

			// Inject our Pokedex Context
			services.AddDbContext<ProfileContext>(o => o.UseSqlServer(Configuration.GetConnectionString("localDb")));

			// Register our Interfaces: transient (created each time requested), scope(once per request), singleton(created first time)
			services.AddScoped<IConfigurationRepository, ConfigurationRepository>();
			services.AddScoped<IMailerService, MailerService>();
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

			// Verify these Cors settings
			app.UseCors(builder => builder
				.WithOrigins("http://localhost:3000")
				.AllowAnyMethod()
				.AllowAnyHeader()
				.AllowCredentials());

			// Set our Automapper for Entites to Dtos
			AutoMapper.Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<PokemonEntity, PokemonModel>();
				cfg.CreateMap<PokemonInsert, PokemonEntity>();
				cfg.CreateMap<ConfigurationEntity, ConfigurationModel>();
				cfg.CreateMap<ConfigurationInsert, ConfigurationEntity>();

			});

			// Handles bouncing http request to the hsts
			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}
