using System.Collections.Generic;
using ProfileWebCore.Models;

namespace Scraper
{
	public interface IPokemonScrapper
	{
		List<PokemonInsert> Scrape();
	}
}