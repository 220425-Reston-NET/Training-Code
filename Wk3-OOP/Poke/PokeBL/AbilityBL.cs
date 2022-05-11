using PokeDL;
using PokeModel;

namespace PokeBL
{
    public class AbilityBL : IAbilityBL
    {
        //====Dependency Injection====
        private IRepository<Ability> _abilityRepo;
        public AbilityBL(IRepository<Ability> p_abilityRepo)
        {
            _abilityRepo = p_abilityRepo;
        }

        //============================

        public List<Ability> GetAllAbility()
        {
            return _abilityRepo.GetAll();
        }

        public Ability SearchAbilityByName(string p_abilityName)
        {
            List<Ability> currentListOfAbility = _abilityRepo.GetAll();

            foreach (Ability abilityObj in currentListOfAbility)
            {
                if (abilityObj.Name == p_abilityName)
                {
                    return abilityObj;
                }
            }

            //Will return null if no ability was found
            return null;
        }
    }
}