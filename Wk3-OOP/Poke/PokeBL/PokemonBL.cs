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

            //Checks if that pokemon name already exists
            Pokemon foundedpokemon = SearchPokemonByName(p_poke.Name);
            if (foundedpokemon == null)
            {
                Repository.AddPokemon(p_poke);
            }
            else
            {
                throw new Exception("Pokemon name already exist");
            }
        }

        public Pokemon SearchPokemonByName(string p_pokeName)
        {
            List<Pokemon> currentListOfPoke = Repository.GetAllPokemon();

            foreach (Pokemon pokeObj in currentListOfPoke)
            {
                //Condition to check that the name is similar
                if (pokeObj.Name == p_pokeName)
                {
                    return pokeObj;
                }
            }

            //Will return null or no value if no pokemon was found
            return null;
        }
    }
}