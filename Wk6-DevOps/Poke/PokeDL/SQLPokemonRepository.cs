using Microsoft.Data.SqlClient;
using PokeModel;

namespace PokeDL
{
    public class SQLPokemonRepository : IRepository<Pokemon>
    {
        //=================== Dependency Injection ==========================
        private string _connectionString;
        
        public SQLPokemonRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }
        
        //=====================Dependency Injection ========================
        
        public void Add(Pokemon p_resource)
        {
            //@ inside the string acts as a parameter
            //We will dynamically change the information there at a later point in this code
            string SQLQuery = @"insert into Pokemon 
                                values (@pokeName, @pokeType, @pokeHealth)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                //We fill in the parameters we added earlier
                //We dynamically change information using AddWithValue and Parameters to avoid the risk of SQL Injection attack
                command.Parameters.AddWithValue("@pokeName", p_resource.Name);
                command.Parameters.AddWithValue("@pokeType", p_resource.Type);
                command.Parameters.AddWithValue("@pokeHealth", p_resource.Health);

                //Execute sql statement that is nonquery meaning it will not give any information back (unlike a select statement)
                command.ExecuteNonQuery();
            }
        }

        public List<Pokemon> GetAll()
        {
            string SQLQuery = @"select * from Pokemon";
            List<Pokemon> listOfPokemon = new List<Pokemon>();

            //SqlConnection object is responsible for establishing a connection to your database
            //Hence why we pass out connectionString information when we construct that object
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                //This opens the connection to the database
                con.Open();

                //SqlCommand object is responsible for executing sql statements to a database
                //It needs a string that is a sql statement
                //It needs a Sqlconnection obj that has a connection to a database
                SqlCommand command = new SqlCommand(SQLQuery, con);

                //SqlDataReader object is responsible for reading information from a SQL Server database (Since it gives tables and tables doesn't exist in C# only objects/classes)
                SqlDataReader reader = command.ExecuteReader();

                //Mapping the table format that SQL understands to a List collection that C# understands
                //While loop because we don't know how many rows there will be in this table
                //reader.Read() method goes from row to row
                while (reader.Read())
                {
                    //We are adding a new Pokemon object to our list collection
                    listOfPokemon.Add(new Pokemon(){

                        //The new pokemon will hold the properties obtained from a single row in SQL
                        //It is Zero-based index meaning the first column would be a 0
                        PokeID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Type = reader.GetString(2),
                        Health = reader.GetInt32(3),
                        Abilities = GiveAbilityToPokemon(reader.GetInt32(0))
                    });
                }

                return listOfPokemon;
            }

        }

        private List<Ability> GiveAbilityToPokemon(int p_pokeId)
        {
            string SQLquery = @"select p.pokeName, a.abName, pa.PP, a.abPower, a.abId from Pokemon p
                        inner join pokemons_abilities pa on p.pokeId = pa.pokeId
                        inner join Ability a on a.abId = pa.abId
                        where p.pokeId = @pokeId";

            List<Ability> listOfAbility = new List<Ability>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLquery, con);

                command.Parameters.AddWithValue("@pokeId", p_pokeId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfAbility.Add(new Ability(){
                        ID = reader.GetInt32(4),
                        Name = reader.GetString(1),
                        Power = reader.GetInt32(3),
                        PP = reader.GetInt32(2)
                    });
                }
            }

            return listOfAbility;
        }

        public void Update(Pokemon p_resource)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pokemon>> GetAllAsync()
        {
            string SQLQuery = @"select * from Pokemon";
            List<Pokemon> listOfPokemon = new List<Pokemon>();

            //SqlConnection object is responsible for establishing a connection to your database
            //Hence why we pass out connectionString information when we construct that object
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                //This opens the connection to the database
                await con.OpenAsync();

                //SqlCommand object is responsible for executing sql statements to a database
                //It needs a string that is a sql statement
                //It needs a Sqlconnection obj that has a connection to a database
                SqlCommand command = new SqlCommand(SQLQuery, con);

                //SqlDataReader object is responsible for reading information from a SQL Server database (Since it gives tables and tables doesn't exist in C# only objects/classes)
                SqlDataReader reader = await command.ExecuteReaderAsync();

                //Mapping the table format that SQL understands to a List collection that C# understands
                //While loop because we don't know how many rows there will be in this table
                //reader.Read() method goes from row to row
                while (await reader.ReadAsync())
                {
                    //We are adding a new Pokemon object to our list collection
                    listOfPokemon.Add(new Pokemon(){

                        //The new pokemon will hold the properties obtained from a single row in SQL
                        //It is Zero-based index meaning the first column would be a 0
                        PokeID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Type = reader.GetString(2),
                        Health = reader.GetInt32(3),
                        Abilities = GiveAbilityToPokemon(reader.GetInt32(0))
                    });
                }

                return listOfPokemon;
            }
        }
    }
}