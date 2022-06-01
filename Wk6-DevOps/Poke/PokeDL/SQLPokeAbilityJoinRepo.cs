using Microsoft.Data.SqlClient;
using PokeModel;

namespace PokeDL
{
    public class SQLPokeAbilityJoinRepo : IRepository<PokemonAbilityJoin>
    {
        //=================== Dependency Injection ==========================
        private string _connectionString;

        public SQLPokeAbilityJoinRepo(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }

        //=====================Dependency Injection ========================
        public void Add(PokemonAbilityJoin p_resource)
        {
            throw new NotImplementedException();
        }

        public List<PokemonAbilityJoin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<PokemonAbilityJoin>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(PokemonAbilityJoin p_resource)
        {
            string SQLquery = @"update pokemons_abilities
                            set PP = @PP
                            where pokeId = @pokeId and abId = @abId";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLquery, con);

                command.Parameters.AddWithValue("@PP", p_resource.PP);
                command.Parameters.AddWithValue("@pokeId", p_resource.pokeId);
                command.Parameters.AddWithValue("@abId", p_resource.abId);

                command.ExecuteNonQuery();
            }
        }
    }
}