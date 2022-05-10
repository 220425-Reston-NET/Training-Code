// See https://aka.ms/new-console-template for more information
using PokeBL;
using PokeUI;

//=====================================
// Useful for debugging model validation
// Console.WriteLine("Hello, World!");

// //Creating an object
// Pokemon pokeObj = new Pokemon();
// pokeObj.PokeID = 100;
// Console.WriteLine(pokeObj.PokeID);
// pokeObj.PokeID = -10;
// Console.WriteLine(pokeObj.PokeID);

// //Adding abilities to obj
// Ability abi1 = new Ability();
// abi1.Name = "Tackle";
// Ability abi2 = new Ability();
// abi2.Name = "Screech";

// pokeObj.Abilities.Add(abi1);
// pokeObj.Abilities.Add(abi2);

// //Display everything that pokemon obj currently has in its abilities
// foreach (Ability item in pokeObj.Abilities)
// {
//     Console.WriteLine(item.Name);
// }
//=======================================

Console.Clear();

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
        menu = new AddPokemon(new PokemonBL());
    }
    else if (ans == "SearchPokemon")
    {
        menu = new SearchPokemon();
    }
    else if (ans == "Exit")
    {
        repeat = false;
    }
}