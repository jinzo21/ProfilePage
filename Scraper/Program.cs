using Ninject;
using System;
using System.Reflection;

namespace Scraper
{
	class Program
	{
		static void Main(string[] args)
		{
			// Load Ninject containter
			var kernel = new StandardKernel();
			kernel.Load(Assembly.GetExecutingAssembly());

			// Scrape and Insert pokemon to DB
			var pokemonScrapper = kernel.Get<IPokemonScrapper>();
			var listOfPokemon = pokemonScrapper.Scrape();

			var repository = kernel.Get<IRepository>();

			foreach (var pokemon in listOfPokemon)
			{
				// here call to insert: repository.InsertPokemon(pokemon);
				Console.WriteLine(pokemon.PokemonName);
			}

			Console.WriteLine($"Total count of pokemon: {listOfPokemon.Count}");
			Console.ReadLine();
		}
	}
}
