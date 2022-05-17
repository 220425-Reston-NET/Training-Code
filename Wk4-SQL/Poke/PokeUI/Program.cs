// See https://aka.ms/new-console-template for more information
global using Serilog;
using PokeBL;
using PokeDL;
using PokeUI;

//Initializing my logger
Log.Logger = new LoggerConfiguration() //LoggerConfiguration used to configure your logger and create it
    .WriteTo.File("./logs/user.txt") //Configuring the logger to save information to a file called user.txt inside of logs folder
    .CreateLogger(); //A method to create the logger

//Creating MainMenu obj
// Another form of polymorphism called Variance
// Variance - that is letting a reference variable have multiple forms/objects hold by having it define as an interface 
IMenu menu = new MainMenu();

bool repeat = true;

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.YourChoice();
    
    if (ans == "MainMenu")
    {
        Log.Information("User going to Main Menu");
        menu = new MainMenu();
    }
    else if (ans == "AddPokemon")
    {
        // Need to add pokemonBL object inside of the parameter
        Log.Information("User going to AddPokemon Menu");
        menu = new AddPokemon(new PokemonBL(new PokemonRepository()));
    }
    else if (ans == "SearchPokemon")
    {
        Log.Information("User going to Search Menu");
        menu = new SearchPokemon(new PokemonBL(new PokemonRepository()));
    }
    else if (ans == "SelectAbility")
    {
        Log.Information("User is selecting ability to a pokemon");
        menu = new SelectAbility(new AbilityBL(new AbilityRepository()), new PokemonBL(new PokemonRepository()));
    }
    else if (ans == "Exit")
    {
        repeat = false;
    }
}