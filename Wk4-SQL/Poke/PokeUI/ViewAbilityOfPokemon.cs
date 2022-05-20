using PokeBL;
using PokeModel;

namespace PokeUI
{
    public class ViewAbilityOfPokemon : IMenu
    {
        //===========Dependency Injection==================

        //field
        private IPokeAbiJoinBL _pokeAbiBL;
        //constructor
        public ViewAbilityOfPokemon(IPokeAbiJoinBL p_pokeAbiBL)
        {
            _pokeAbiBL = p_pokeAbiBL;
        }


        //===========Dependency Injection==================

        public void Display()
        {
            Console.WriteLine("===Current Ability of Pokemon===");
            foreach (Ability abilityObj in SearchPokemon.foundedPokemon.Abilities)
            {
                Console.WriteLine(abilityObj);
            }
            Console.WriteLine("[1] - Replenish PP of an ability");
            Console.WriteLine("[0] - Go back");
        }

        public string YourChoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                return "SearchPokemon";
            }
            else if (userInput == "1")
            {
                //Logic to select which ability does the user want
                Console.WriteLine("Enter the ID of the ability you want to replenish");
                int abId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much PP do you want to add to this ability");
                int PP = Convert.ToInt32(Console.ReadLine());

                _pokeAbiBL.ReplenishAbilityPP(PP, abId, SearchPokemon.foundedPokemon.PokeID);

                Console.WriteLine("Successfully updated the PP");
                Console.ReadLine();

                return "SearchPokemon";
            }
            else
            {
                return "MainMenu";
            }
        }
    }
}