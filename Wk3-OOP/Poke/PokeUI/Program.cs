// See https://aka.ms/new-console-template for more information
using PokeBL;
using PokeDL;
using PokeUI;

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
        menu = new MainMenu();
    }
    else if (ans == "AddPokemon")
    {
        // Need to add pokemonBL object inside of the parameter
        menu = new AddPokemon(new PokemonBL(new PokemonRepository()));
    }
    else if (ans == "SearchPokemon")
    {
        menu = new SearchPokemon(new PokemonBL(new PokemonRepository()));
    }
    else if (ans == "SelectAbility")
    {
        menu = new SelectAbility(new AbilityBL(new AbilityRepository()), new PokemonBL(new PokemonRepository()));
    }
    else if (ans == "Exit")
    {
        repeat = false;
    }
}