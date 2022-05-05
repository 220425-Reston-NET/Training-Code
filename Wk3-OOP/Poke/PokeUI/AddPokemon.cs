using PokeDL;
using PokeModel;

public class AddPokemon : IMenu
{
    private Pokemon pokeObj = new Pokemon();

    public void Display()
    {
        Console.WriteLine("Please enter the pokemon details by following the questions");
        Console.WriteLine("What is the pokemon name?");
        pokeObj.Name = Console.ReadLine();
        Console.WriteLine("What is the pokemon type?");
        pokeObj.Type = Console.ReadLine();
        Console.WriteLine("What is the pokeID?");
        pokeObj.PokeID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("[1] - Add the pokemon");
        Console.WriteLine("[0] - Exit");
    }

    public string YourChoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            Repository.AddPokemon(pokeObj);
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