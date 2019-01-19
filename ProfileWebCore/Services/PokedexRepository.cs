using ProfileWebCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileWebCore.Services
{
	public class PokedexRespority : IPokedexRepository
	{
		private readonly ProfileContext _profileContext;

		public PokedexRespority(ProfileContext pokemonContext)
		{
			_profileContext = pokemonContext;
		}

		public List<PokemonEntity> GetPokemon()
		{
			return _profileContext.Pokemon.ToList();
		}

		public PokemonEntity GetPokemonByName(string pokemonName)
		{
			return _profileContext.Pokemon.Where(p => p.PokemonName == pokemonName).FirstOrDefault();
		}

		public void InsertPokemon(PokemonEntity pokemon)
		{
			_profileContext.Add(pokemon);
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
