using PokeModel;

namespace PokeUI
{
    public class ViewAbilityOfPokemon : IMenu
    {
        public void Display()
        {
            Console.WriteLine("===Current Ability of Pokemon===");
            foreach (Ability abilityObj in SearchPokemon.foundedPokemon.Abilities)
            {
                Console.WriteLine(abilityObj);
            }
            Console.WriteLine("[0] - Go back");
        }

        public string YourChoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                return "SearchPokemon";
            }
            else
            {
                return "MainMenu";
            }
        }
    }
}