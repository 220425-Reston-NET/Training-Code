using PokeDL;
using PokeModel;

namespace PokeBL
{
    public class PokemonBL : IPokemonBL
    {
        public void AddPokemon(Pokemon p_poke)
        {
            //Processing data
            //We randomize the potential stat we get when we add a pokemon to the database
            Random rand = new Random();
            p_poke.Health = rand.Next(50);

            Repository.AddPokemon(p_poke);
        }

        public List<Pokemon> SearchPokemonByName(string p_pokeName)
        {
            throw new NotImplementedException();
        }
    }
}