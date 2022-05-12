using PokeModel;

namespace PokeUI
{
    public class MainMenu : IMenu
    {

        //This method will display things in your terminal that will show what the user can do
        public void Display()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What can I do for you?");
            Console.WriteLine("[2] - Add a new pokemon");
            Console.WriteLine("[1] - Search Pokemon");
            Console.WriteLine("[0] - Exit");
        }

        //This method will ask the user what to do
        public string YourChoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "2")
            {
                //We return what we think the menu should display next when that person picked that choice
                //In this case it will display the AddPokemon menu instead
                return "AddPokemon";
            }
            else if (userInput == "1")
            {
                return "SearchPokemon";
            }
            else if (userInput == "0")
            {
                return "Exit";
            }
            else
            {
                Console.WriteLine("Please input a valid response");
                return "MainMenu";
            }
        }
    }
}