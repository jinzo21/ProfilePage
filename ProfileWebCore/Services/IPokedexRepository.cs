using ProfileWebCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileWebCore.Services
{
	public interface IPokedexRepository
	{
		List<PokemonEntity> GetPokemon();
		PokemonEntity GetPokemonByName(string pokemonName);
		void InsertPokemon(PokemonEntity pokemonDto);
		bool Save();
	}
}
