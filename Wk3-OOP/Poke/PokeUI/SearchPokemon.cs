public class SearchPokemon : IMenu
{
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
            return "MainMenu";
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