using PokeDL;
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
            Console.WriteLine("[1] - Add a new pokemon");
            Console.WriteLine("[0] - Exit");
        }

        //This method will ask the user what to do
        public string YourChoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                //Logic add pokemon
                Console.Clear();
                Pokemon pokeobj = new Pokemon();
                Console.WriteLine("What is the name of the pokemon?");
                pokeobj.Name = Console.ReadLine();
                Console.WriteLine("What is the Type of the pokemon?");
                pokeobj.Type = Console.ReadLine();
                Console.WriteLine("What is the PokeID?");
                //Since PokeId is a integer and Console.ReadLine() gives a string, we have to convert to int
                pokeobj.PokeID = Convert.ToInt32(Console.ReadLine());

                Repository.AddPokemon(pokeobj);
                return "AddPokemon";
            }
            else if (userInput == "0")
            {
                //Logic to exit
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