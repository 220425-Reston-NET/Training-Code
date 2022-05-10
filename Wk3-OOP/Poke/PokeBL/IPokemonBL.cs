using PokeModel;

namespace PokeBL
{
    /// <summary>
    /// Business Layer is responsible for further validation or process of data obtained from the database or the user
    /// What kind of process? That all depends on the type of functionality you will be doing
    /// </summary>
    public interface IPokemonBL
    {
        
        /// <summary>
        /// Add pokemon to the database
        /// Randomize the health property of the pokemon
        /// </summary>
        /// <param name="p_poke">This is the pokemon object that will be added to the DB</param>
        /// <returns>Gives back the pokemon that gets added to the DB</returns>
        void AddPokemon(Pokemon p_poke);

        /// <summary>
        /// This will search for a pokemon in the DB using their name
        /// </summary>
        /// <param name="p_pokeName">Name of the pokemon used to search</param>
        /// <returns>Multiple pokemons if they have matching name</returns>
        Pokemon SearchPokemonByName(string p_pokeName);
        
        // List<Pokemon> SearchPokemonById(int p_pokeId);
    }
}
