using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProfileWebCore.Data;
using ProfileWebCore.Models;
using ProfileWebCore.Services;

namespace ProfileWebCore.Controllers
{
	[Route("pokedex")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokedexRepository _pokedexRepository;

        public PokemonController(IPokedexRepository pokedexRepository)
        {
            _pokedexRepository = pokedexRepository;
        }

        [HttpGet("pokemon")]
        public IActionResult GetPokemon()
        {
			var pokemonEntityList = _pokedexRepository.GetPokemon();

			// Map from Entity list do Dto list
			var results = Mapper.Map<List<PokemonModel>>(pokemonEntityList);

			return Ok(results);
        }

        [HttpGet("pokemon/{name}")]
        public IActionResult GetPokemonByName([FromRoute] string name)
        {
			var pokemon = _pokedexRepository.GetPokemonByName(name);

			if (pokemon == null)
			{
				return NotFound();
			}

			// Map from Pokemon entity to dto
			var pokemonResult = Mapper.Map<PokemonModel>(pokemon);

			return Ok(pokemonResult);
        }

		//// PUT: api/Pokemon/5
		//[HttpPut("pokemon/{id}")]
		//public async Task<IActionResult> PutPokemonModel([FromRoute] int id, [FromBody] PokemonModel pokemonModel)
		//{
		//    if (!ModelState.IsValid)
		//    {
		//        return BadRequest(ModelState);
		//    }

		//    if (id != pokemonModel.Id)
		//    {
		//        return BadRequest();
		//    }

		//    _pokedexRepository.Entry(pokemonModel).State = EntityState.Modified;

		//    try
		//    {
		//        await _pokedexRepository.SaveChangesAsync();
		//    }
		//    catch (DbUpdateConcurrencyException)
		//    {
		//        if (!PokemonModelExists(id))
		//        {
		//            return NotFound();
		//        }
		//        else
		//        {
		//            throw;
		//        }
		//    }

		//    return NoContent();
		//}

		// POST: api/Pokemon

		[HttpPost("pokemon")]
        public IActionResult InsertPokemon([FromBody] PokemonInsert pokemonModel)
        {
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var pokemonInsert = Mapper.Map<PokemonEntity>(pokemonModel);
			_pokedexRepository.InsertPokemon(pokemonInsert);

			if (!_pokedexRepository.Save())
			{
				return StatusCode(500, "A problem happened while handling your request");
			}

			return StatusCode(201);
		}

        //// DELETE: api/Pokemon/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePokemonModel([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var pokemonModel = await _pokedexRepository.PokemonEntity.FindAsync(id);
        //    if (pokemonModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _pokedexRepository.PokemonEntity.Remove(pokemonModel);
        //    await _pokedexRepository.SaveChangesAsync();

        //    return Ok(pokemonModel);
        //}

        //private bool PokemonModelExists(int id)
        //{
        //    return _pokedexRepository.PokemonEntity.Any(e => e.Id == id);
        //}
    }
}