using PokeDL;
using PokeModel;

namespace PokeBL
{
    public class PokemonBL : IPokemonBL
    {
        //================== Dependency Injection ====================
        private IRepository<Pokemon> _pokeRepo;
        public PokemonBL(IRepository<Pokemon> p_pokeRepo)
        {
            _pokeRepo = p_pokeRepo;
        }

        public void AddAbilityToPokemon(Pokemon p_pokemon)
        {
            //Logic to update pokemon
            _pokeRepo.Update(p_pokemon);
        }

        //============================================================

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
                _pokeRepo.Add(p_poke);
            }
            else
            {
                throw new Exception("Pokemon name already exist");
            }
        }

        public List<Pokemon> GetAllPokemon()
        {
            return _pokeRepo.GetAll();
        }

        public Pokemon SearchPokemonById(int p_id)
        {
            List<Pokemon> currentListOfPoke = _pokeRepo.GetAll();

            foreach (Pokemon pokeObj in currentListOfPoke)
            {
                //Condition to check that the name is similar
                if (pokeObj.PokeID == p_id)
                {
                    return pokeObj;
                }
            }

            //Will return null or no value if no pokemon was found
            return null;
        }

        public Pokemon SearchPokemonByName(string p_pokeName)
        {
            List<Pokemon> currentListOfPoke = _pokeRepo.GetAll();

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