using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PokeBL;
using PokeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        //=================Dependency Injection=============
        private IPokemonBL _pokeBL;
        private IPokeAbiJoinBL _pokeJoin;

        public PokemonController(IPokemonBL pokeBL, IPokeAbiJoinBL pokeJoin)
        {
            _pokeBL = pokeBL;
            _pokeJoin = pokeJoin;
        }

        //=================================================

        //Data annotation to indicate what type of HTTP verb it is
        //This is an action of a controller
        //It needs what HTTP verb it is associated with
        [HttpGet("GetAllPokemon")]
        public async Task<IActionResult> GetAllPokemon()
        {
            try
            {
                List<Pokemon> listOfCurrentPokemon = await _pokeBL.GetAllPokemonAsync();
    
                //Followed by "Ok()" it determines what http status code to give
                return Ok(listOfCurrentPokemon);
            }
            catch (SqlException)
            {
                return NotFound("No Pokemon Exist");
            }
        }

        [HttpPost("AddPokemon")]
        public IActionResult AddPokemon([FromBody] Pokemon p_poke)
        {
            try
            {
                _pokeBL.AddPokemon(p_poke);

                return Created("Pokemon was created!", p_poke);
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        [HttpGet("SearchPokemonByName")]
        public IActionResult SearchPokemon([FromQuery] string pokeName)
        {
            try
            {
                return Ok(_pokeBL.SearchPokemonByName(pokeName));
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        [HttpPut("ReplenishPP")]
        public IActionResult ReplenishPP([FromQuery] int p_PP, [FromQuery] int p_abId, [FromQuery] int p_pokeId)
        {
            Pokemon found = _pokeBL.SearchPokemonById(p_pokeId);

            if (found == null)
            {
                return NotFound("Pokemon was not found!");
            }
            //Another logic to check if the pokemon has the ability
            else
            {
                try
                {
                    _pokeJoin.ReplenishAbilityPP(p_PP, p_abId, p_pokeId);

                    return Ok();
                }
                catch (SqlException)
                {
                    return Conflict();
                    
                }

            }
        }
    }
}
