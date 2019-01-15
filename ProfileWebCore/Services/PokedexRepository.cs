using ProfileWebCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileWebCore.Services
{
	public class PokedexRespority : IPokedexRepository
	{
		private readonly PokedexContext PokedexContext;

		public PokedexRespority(PokedexContext pokemonContext)
		{
			PokedexContext = pokemonContext;
		}

		public List<PokemonEntity> GetPokemon()
		{
			return PokedexContext.Pokemon.ToList();
		}

		public PokemonEntity GetPokemonByName(string pokemonName)
		{
			return PokedexContext.Pokemon.Where(p => p.PokemonName == pokemonName).FirstOrDefault();
		}

		public void InsertPokemon(PokemonEntity pokemon)
		{
			PokedexContext.Add(pokemon);
		}

		/// <summary>
		/// Returns bool if there was an item changed
		/// </summary>
		/// <returns>Bool</returns>
		public bool Save()
		{
			return (PokedexContext.SaveChanges() >= 0);
		}
	}

}
