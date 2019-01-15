using System.Net;
using AngleSharp.Html.Parser;
using System.Collections.Generic;
using ProfileWebCore.Models;

namespace Scraper
{
	public class PokemonScrapper : IPokemonScrapper
	{
		public List<PokemonInsertModel> Scrape()
		{
			// List of Pokemon
			var pokemonList = new List<PokemonInsertModel>();

			//Create new instance of WebClient
			var WebClient = new WebClient();

			//Set HTML = the result of DownloadString
			var html = WebClient.DownloadString("http://pokedream.com/pokedex/pokemon?display=gen1");

			//Parse the data
			var parser = new HtmlParser();
			var document = parser.ParseDocument(html);

			//Select the table which has pokemon data
			var table = document.QuerySelector("tbody");
			var rows = table.QuerySelectorAll("tr");

			foreach (var row in rows)
			{
				var name = row.QuerySelector("td");

				if (name != null)
				{
					var WebClientTwo = new WebClient();

					var htmlTwo = WebClientTwo.DownloadString("http://pokedream.com/pokedex/pokemon/" + name.TextContent);

					var parserTwo = new HtmlParser();
					var documentTwo = parserTwo.ParseDocument(htmlTwo);

					PokemonInsertModel currentPokemon = new PokemonInsertModel();

					// Pokemon Table
					var pokemonTable = documentTwo.QuerySelectorAll("tbody")[1];
					
					// Pokemon Pic
					var pokemonTableRowZero = pokemonTable.QuerySelectorAll("tr")[0];
					var pokemonTableDataZero = pokemonTableRowZero.QuerySelector("#picture");
					currentPokemon.PokemonImage = pokemonTableDataZero.QuerySelector("img").GetAttribute("src");

					// Pokemon Name
					currentPokemon.PokemonName = pokemonTableDataZero.QuerySelector("img").GetAttribute("alt");

					// Pokemon Id
					currentPokemon.PokemonId = documentTwo.QuerySelector("h1 span").TextContent;
					
					// Pokemon Type
					var pokemonTableDataOne = pokemonTableRowZero.QuerySelectorAll("td")[1];
					currentPokemon.PokemonType = pokemonTableDataOne.QuerySelector("img").GetAttribute("alt");
					
					// Pokemon Height
					var pokemonTableRowTwo = pokemonTable.QuerySelectorAll("tr")[2];
					currentPokemon.PokemonHeight = pokemonTableRowTwo.QuerySelectorAll("td")[0].TextContent;
					
					// Pokemon Weight
					var pokemonTableRowThree = pokemonTable.QuerySelectorAll("tr")[3];
					currentPokemon.PokemonWeight = pokemonTableRowThree.QuerySelectorAll("td")[0].TextContent;

					// Discription Table
					var pokemonTableDisc = documentTwo.QuerySelector("#flavortext");
					var pokemonTableDiscRowYellow = pokemonTableDisc.QuerySelectorAll("tr")[0];
					currentPokemon.PokemonDescription = pokemonTableDiscRowYellow.QuerySelectorAll("td")[1].TextContent;

					// Pokemon Stats
					var pokemonTableStats = documentTwo.QuerySelector("#stats");
					var pokemonTableStatsRowOne = pokemonTableStats.QuerySelectorAll("tr")[1];
					currentPokemon.StatHp = pokemonTableStatsRowOne.QuerySelectorAll("td")[0].TextContent;
					var pokemonTableStatsRowTwo = pokemonTableStats.QuerySelectorAll("tr")[2];
					currentPokemon.StatAttack = pokemonTableStatsRowTwo.QuerySelectorAll("td")[0].TextContent;
					var pokemonTableStatsRowThree = pokemonTableStats.QuerySelectorAll("tr")[3];
					currentPokemon.StatDefense = pokemonTableStatsRowThree.QuerySelectorAll("td")[0].TextContent;
					var pokemonTableStatsRowFour = pokemonTableStats.QuerySelectorAll("tr")[4];
					currentPokemon.StatSpAttack = pokemonTableStatsRowFour.QuerySelectorAll("td")[0].TextContent;
					var pokemonTableStatsRowFive = pokemonTableStats.QuerySelectorAll("tr")[5];
					currentPokemon.StatSpDefense = pokemonTableStatsRowFive.QuerySelectorAll("td")[0].TextContent;
					var pokemonTableStatsRowSix = pokemonTableStats.QuerySelectorAll("tr")[6];
					currentPokemon.StatSpeed = pokemonTableStatsRowSix.QuerySelectorAll("td")[0].TextContent;
					var pokemonTableStatsRowSeven = pokemonTableStats.QuerySelectorAll("tr")[7];
					currentPokemon.StatTotal = pokemonTableStatsRowSeven.QuerySelectorAll("td")[0].TextContent;

					// Pokemon Pics
					var pokemonTableIamges = documentTwo.QuerySelector("#images");
					var pokemonTableIamgesDataTwo = pokemonTableIamges.QuerySelectorAll("td")[1];
					currentPokemon.PokemonImageSFront = pokemonTableIamgesDataTwo.QuerySelectorAll("img")[0].GetAttribute("src");
					currentPokemon.PokemonImageSBack = pokemonTableIamgesDataTwo.QuerySelectorAll("img")[2].GetAttribute("src");

					pokemonList.Add(currentPokemon);
				}
			}

			return pokemonList;
		}
	}
}
