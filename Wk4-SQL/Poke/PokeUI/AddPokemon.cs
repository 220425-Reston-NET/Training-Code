using PokeBL;
using PokeModel;

public class AddPokemon : IMenu
{
    private Pokemon pokeObj = new Pokemon();

    //====== Dependency Injection Pattern =======
    //Add the field of the interface you are trying to add
    private IPokemonBL _pokeBL;

    //Create a constructor with a parameter of that interface
    public AddPokemon(IPokemonBL p_pokeBL)
    {
        //Set the field with the parameter
        _pokeBL = p_pokeBL;
    }

    //NOTE: Look into your program.cs and fix the red line
    //===========================================


    public void Display()
    {
        Console.WriteLine("Please enter the pokemon details by following the questions");
        Console.WriteLine("What is the pokemon name?");
        pokeObj.Name = Console.ReadLine();
        Console.WriteLine("What is the pokemon type?");
        pokeObj.Type = Console.ReadLine();
        Console.WriteLine("What is the pokeID?");

        try
        {
            pokeObj.PokeID = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Log.Warning("User tried to add a negative number!");
            Console.WriteLine("PokeId Cannot be negative!");
            pokeObj.PokeID = 1;
        }

        Console.WriteLine("[1] - Add the pokemon");
        Console.WriteLine("[0] - Exit");
    }

    public string YourChoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            // Repository.AddPokemon(pokeObj);
            try
            {
                _pokeBL.AddPokemon(pokeObj);
            }
            catch (System.Exception)
            {
                Log.Warning("Pokemon name already exist!");
                Log.Information(pokeObj.ToString());
                Console.WriteLine("Pokemon name already exist!");
                Console.ReadLine();
            }

            return "MainMenu";
        }
        else if (userInput == "0")
        {
            return "Exit";
        }
        else
        {
            Console.WriteLine("Please enter a correct response");
            return "AddPokemon";
        }
    }
}