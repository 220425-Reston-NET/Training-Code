
using System.Text.Json;
/// <summary>
/// Serialization is th process of converting your objects into stream of bytes (000111001), JSON (JavaScript Object Notation), or XML 
/// We will be using JSON file since it is the most popular format for storing and transfering data to other computers
///  </summary>
public class Serialization
{
    private string _filepath = "./Data/Car.json";

    public void SerializationMain()
    {
        Console.WriteLine("===Serialization Demo===");

        //Create a car object we are going to store
        Car carobj = new Car()
        {
            Owner = "Maaz",
            Fuel = 100,
            Brand = "Toyota"
        };

        /*
            We will use a premade class called JsonSerializer that was made for serialization converting C# objects into JSON
            JsonSerializer has a Serialize method that will convert the C# object into a string datatype that follows the JSON format
            JsonSerializerOptions object is used to configure the JsonSerializer to make it more readable
        */
        string jsonString = JsonSerializer.Serialize(carobj, new JsonSerializerOptions(){WriteIndented = true});
        Console.WriteLine(jsonString);
        
        /*
            We will use a premade class called File that can be used to read/write files
            WriteAllText method will create a file if no file exists and use the jsonString to store that information in that file
        */
        File.WriteAllText(_filepath, jsonString);
        //Next step is reading that file and storing it in a C# object

        try
        {
            //We need to read the file first to get the information back from the JSON file
            string jsonString2 = File.ReadAllText(_filepath);
            Console.WriteLine(jsonString2);

            //Deserialize method will convert the jsonString back into a car object
            Car carobj2 = JsonSerializer.Deserialize<Car>(jsonString2);
            Console.WriteLine(carobj2.Owner);
            
        }
        //FileNotFoundException means that the Car.json doesn't exist and it tried reading it
        catch (FileNotFoundException)
        {
            Car carobj3 = new Car();
            string jsonString3 = JsonSerializer.Serialize(carobj3);

            File.WriteAllText(_filepath, jsonString3);
            string jsonString4 = File.ReadAllText(_filepath);
            Console.WriteLine(jsonString4);
        }
        //You can have more catch blocks perfectly fine
        //Generally the lower catch blocks will be more for generic exceptions
        catch (System.Exception)
        {
            throw new System.Exception("You can specify message");
        }
        //This will always run regardless if an except was caught or not
        finally
        {
            //Used for code clean up
        }




    }
}