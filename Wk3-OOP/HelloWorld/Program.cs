// See https://aka.ms/new-console-template for more information
using Day4;
using Day5;

Console.Clear(); //Will clear the console
Console.WriteLine("Hello, World!"); //Writeline will write something in the terminal

//[Class name] [NameOfObject] = new [Class name]();
Car carObj1 = new Car();

//Referencing class members within an object
int mile = carObj1.TotalDistancePerFuel();

carObj1.Sum(5, 10);

Console.WriteLine(mile);

Console.WriteLine("End of Method");
string owner = "Chadel";

Car carObj2 = new Car(owner);
Console.WriteLine(carObj2.Owner);
carObj2.Owner = "Maaz";
Console.WriteLine(carObj2.Owner);

//Checking if our property constraints is working
carObj2.Fuel = -100;
Console.WriteLine(carObj2.Fuel);

Car.Registration = true;

carObj1.GetRegistration();
carObj2.GetRegistration();

Car.Registration = false;

carObj1.GetRegistration();
carObj2.GetRegistration();

//Menu Demo
Menu menuObj = new Menu();
// bool repeat = true;

// Console.WriteLine("Hello! What is your name?");
// menuObj.Name = Console.ReadLine();

// while (repeat)
// {
//     menuObj.GreetUser();
//     string answer = Console.ReadLine();
//     if (answer == "1")
//     {
//         menuObj.BuyItem();
//     }
//     else if (answer == "2")
//     {
//         Console.WriteLine("Your total price is " + menuObj.TotalPrice);
//         repeat = false;
//     }
// }

Collections collectObj = new Collections();
collectObj.CollectionMain();

Conversions.ConversionMain();

// Data.DataMain();

Serialization serialobj = new Serialization();
serialobj.SerializationMain();

Console.WriteLine("===OOP Demo===");
Dog dogobj = new Dog();
dogobj.Name = "Minnie";
dogobj.Talk();
dogobj.Run();
dogobj.Talk("Barking!");
dogobj.Breed = "Chihuahua";

Animal aniobj = new Animal();
aniobj.Name = "McCoy";
aniobj.Run();
// aniobj.Breed This doesn't work because inheritance only works one way. Only the dog gets everything from the animal and the animal doesn't inherit from the dog
aniobj.Health();

IAnimal aniobj2 = new Animal();
aniobj2.Health();

ConversionsTwo.ConversionTwoMain();

Generics<string>.Add("10","213");