using System.Text.Json;
using PokeModel;

namespace PokeDL
{
    //This class is responsible for storing and reading our data
    public class PokemonRepository : IRepository<Pokemon>
    {
        private string _filepath = "../PokeDL/Data/Pokemon.json";

        //Purpose of this method is to add a pokemon to our data
        public void Add(Pokemon p_poke)
        {
            List<Pokemon> listOfPoke = GetAll();
            listOfPoke.Add(p_poke);

            string jsonString = JsonSerializer.Serialize(listOfPoke, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }

        public List<Pokemon> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Pokemon> listOfPokemon = JsonSerializer.Deserialize<List<Pokemon>>(jsonString);

            return listOfPokemon;
        }

        public Task<List<Pokemon>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Pokemon p_resource)
        {
            // Current information from the database
            List<Pokemon> listOfPokemon = GetAll();

            //Finds the matching pokemon object in the database
            foreach (Pokemon pokeObj in listOfPokemon)
            {
                //Condition to find the same pokemon
                if (pokeObj.Name == p_resource.Name)
                {
                    //Saves this information to the list collection
                    pokeObj.Abilities = p_resource.Abilities;
                }
            }

            //Saves this information to the database
            string jsonString = JsonSerializer.Serialize(listOfPokemon, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);   
        }
    }

}
