public class Asynchronous
{
    /*
        In the context of cooking something
        As you know with cooking shows, to expedite the process of getting a finish prodcut, they would cook things seperate and at the same time
        We can do the same thing with code to also try and be efficient by running things at the same time

        You can think of a Task as a little worker bee that will do the method and then die afterwards
    */

    public async Task<string> CookRice()
    {
        Console.WriteLine("Started cooking the Rice...");
        await Task.Delay(5000);//This line just stops the program for 5000 milliseconds or 5 seconds
        return "Finishing cooking the rice";
    }
    public async Task<string> CookMeat()
    {
        Console.WriteLine("Started cooking the Meat...");
        await Task.Delay(3000);//This line just stops the program for 5000 milliseconds or 5 seconds
        return "Finishing cooking the meat";
    }

    public async Task<string> CookVeggies()
    {
        Console.WriteLine("Started cooking the Veggies...");
        await Task.Delay(1000);//This line just stops the program for 5000 milliseconds or 5 seconds
        return "Finishing cooking the veggies";
    }
}