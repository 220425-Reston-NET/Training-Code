// See https://aka.ms/new-console-template for more information


using PokeModel;

Console.WriteLine("Hello, World!");

//Creating an object
Pokemon obj = new Pokemon();
obj.PokeID = 100;
Console.WriteLine(obj.PokeID);
obj.PokeID = -10;
Console.WriteLine(obj.PokeID);