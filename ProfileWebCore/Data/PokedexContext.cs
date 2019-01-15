using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfileWebCore.Models;

namespace ProfileWebCore.Data
{
	public class PokedexContext : DbContext
	{
		// Base class allows you to access the DbContext constructor (the base constructor)
		public PokedexContext(DbContextOptions<PokedexContext> options) : base(options)
		{
			// If db does not exist this will create it
			//Database.EnsureCreated();

			// Using migrations: if no Db exists it generates one
			Database.Migrate();
		}

		public DbSet<PokemonEntity> Pokemon { get; set; }

	}
}
