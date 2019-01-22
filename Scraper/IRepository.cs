using ProfileWebCore.Models;

namespace Scraper
{
	public interface IRepository
	{
		void InsertPokemon(PokemonInsert pokemon);
	}
}