using PokeBL;
using PokeModel;

public class SearchPokemon : IMenu
{

    //===========Dependency Injection===========
    private IPokemonBL _pokeBL;
    public SearchPokemon(IPokemonBL p_pokeBL)
    {
        _pokeBL = p_pokeBL;
    }
    //==========================================
    public void Display()
    {
        Console.WriteLine("How would you like to search your pokemon?");
        Console.WriteLine("[3] - Search by PokeId");
        Console.WriteLine("[2] - Search by Name");
        Console.WriteLine("[1] - Search by Type");
        Console.WriteLine("[0] - Exit");
    }

    public string YourChoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "3")
        {
            //Search logic by PokeId
            return "MainMenu";
        }
        else if (userInput == "2")
        {
            //Search logic by name
            Console.WriteLine("Enter a pokemon name: ");
            string pokeName = Console.ReadLine();
            
            Pokemon foundedPokemon = _pokeBL.SearchPokemonByName(pokeName);

            //Condition that it should only display the pokemon info if it found a pokemon
            if (foundedPokemon == null)
            {
                Console.WriteLine("Pokemon was not found!");
            }
            else
            {
                Console.WriteLine("===Pokemon Info===");
                Console.WriteLine("Name: " + foundedPokemon.Name);
                Console.WriteLine("Type: "+ foundedPokemon.Type);
                Console.WriteLine("Health: " + foundedPokemon.Health);
                Console.WriteLine("==============");
            }

            //Acting like a stopping point so we can display information
            Console.ReadLine();

            return "SearchPokemon";
        }
        else if (userInput == "1")
        {
            //Search logic by type
            return "MainMenu";
        }
        else if (userInput == "0")
        {
            //Exit
            return "MainMenu";
        }
        else
        {
            Console.WriteLine("Please enter a valid response");
            return "SearchPokemon";
        }
    }
}