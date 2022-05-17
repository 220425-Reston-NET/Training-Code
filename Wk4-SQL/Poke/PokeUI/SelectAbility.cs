using PokeBL;
using PokeModel;

namespace PokeUI
{
    public class SelectAbility : IMenu
    {
        //====Dependency Injection====
        private IAbilityBL _abilityBL;
        private IPokemonBL _pokeBL;
        public SelectAbility(IAbilityBL p_abilityBL, IPokemonBL p_pokeBL)
        {
            _abilityBL = p_abilityBL;
            _pokeBL = p_pokeBL;
        }
        //============================
        public void Display()
        {
            //This will display all abilities currently available in the database
            List<Ability> listOfAbility = _abilityBL.GetAllAbility();
            foreach (Ability abilityObj in listOfAbility)
            {
                Console.WriteLine(abilityObj.Name);
            }
        }

        public string YourChoice()
        {
            Console.WriteLine("Give me the ability name listed above to choose an ability?");
            string userInput = Console.ReadLine();
            
            //Logic to select a specific ability in our listOfAbility variable
            Ability foundedAbility = _abilityBL.SearchAbilityByName(userInput);

            //Validation for userInput
            if (foundedAbility != null)
            {
                //Logic adds the ability to the founded pokemon using the abilities property in its model
                SearchPokemon.foundedPokemon.Abilities.Add(foundedAbility);
                _pokeBL.AddAbilityToPokemon(SearchPokemon.foundedPokemon);
                Console.WriteLine("Successfully added ability!");
            }
            else
            {
                Console.WriteLine("Ability was unable to be found! Please enter the exact name (case sensitive)");
                Console.ReadLine();
                return "SelectAbility";
            }


            //Logic to save that information permanently (UPDATING)
            Console.ReadLine();
            return "MainMenu";
        }
    }
}