using System.Text.Json;
using PokeModel;

namespace PokeDL
{
    //This class is responsible for storing and reading our data
    public class Repository
    {
        private static string _filepath = "../PokeDL/Data/Pokemon.json";

        //Purpose of this method is to add a pokemon to our data
        public static void AddPokemon(Pokemon p_poke)
        {
            List<Pokemon> listOfPoke = GetAllPokemon();
            listOfPoke.Add(p_poke);

            string jsonString = JsonSerializer.Serialize(listOfPoke, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);

            // return p_poke;
        }

        public static List<Pokemon> GetAllPokemon()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Pokemon> listOfPokemon = JsonSerializer.Deserialize<List<Pokemon>>(jsonString);

            return listOfPokemon;
        }
    }

}
