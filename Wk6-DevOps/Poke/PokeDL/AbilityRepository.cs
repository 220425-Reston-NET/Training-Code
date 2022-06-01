using System.Text.Json;
using PokeModel;

namespace PokeDL
{
    public class AbilityRepository : IRepository<Ability>
    {
        private string _filepath = "../PokeDL/Data/Ability.json";
        public void Add(Ability p_resource)
        {
            throw new NotImplementedException();
        }

        public List<Ability> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Ability> listOfAbility = JsonSerializer.Deserialize<List<Ability>>(jsonString);

            return listOfAbility;
        }

        public Task<List<Ability>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Ability p_resource)
        {
            throw new NotImplementedException();
        }
    }
}