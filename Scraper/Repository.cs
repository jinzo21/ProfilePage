using ProfileWebCore.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Scraper
{
	public class Repository : IRepository
	{
		public void InsertPokemon(PokemonInsert pokemon)
		{
			using (var con = new SqlConnection(Environment.GetEnvironmentVariable("ConnectionString")))
			{
				//Create Connection to DB
				con.Open();

				//Create Command for Stored Procedure
				var cmd = con.CreateCommand();
				cmd.CommandText = "pokedex_scraper_insert";
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				//Pass Parameter
				cmd.Parameters.AddWithValue("@pokemonId", pokemon.PokemonId);
				cmd.Parameters.AddWithValue("@pokemonName", pokemon.PokemonName);
				cmd.Parameters.AddWithValue("@pokemonDescription", pokemon.PokemonDescription);
				cmd.Parameters.AddWithValue("@pokemonHeight", pokemon.PokemonHeight);
				cmd.Parameters.AddWithValue("@pokemonWeight", pokemon.PokemonWeight);
				cmd.Parameters.AddWithValue("@pokemonType", pokemon.PokemonType);
				cmd.Parameters.AddWithValue("@pokemonImage", pokemon.PokemonImage);
				cmd.Parameters.AddWithValue("@pokemonImageSFront", pokemon.PokemonImageSFront);
				cmd.Parameters.AddWithValue("@pokemonImageSBack", pokemon.PokemonImageSBack);
				cmd.Parameters.AddWithValue("@statHp", pokemon.StatHp);
				cmd.Parameters.AddWithValue("@statAttack", pokemon.StatAttack);
				cmd.Parameters.AddWithValue("@statDefense", pokemon.StatDefense);
				cmd.Parameters.AddWithValue("@statSpAttack", pokemon.StatSpAttack);
				cmd.Parameters.AddWithValue("@statSpDefense", pokemon.StatSpDefense);
				cmd.Parameters.AddWithValue("@statSpeed", pokemon.StatSpeed);
				cmd.Parameters.AddWithValue("@statTotal", pokemon.StatTotal);

				//No Expected Outputs
				cmd.ExecuteNonQuery();
			}
		}
	
	}
}
