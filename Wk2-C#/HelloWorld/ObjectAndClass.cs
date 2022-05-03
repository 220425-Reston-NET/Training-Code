//This is how you create a class by using the class keyword
//Public is just there to make the class available for everyone
public class Car
{
    //This is a field
    //It is used to store information or define the current state of the object
    //By default, fields should all be private
    //private means that only the class itself has access to it
    private string _color;
    //string is used for words/sentences
    private string _owner;
    //int is used for whole numbers
    private int _fuel;
    private int _gallonPerMile;

    //This is a method
    //A way to represent behavior/function and it will run multiple lines of code
    //void means that the method will not return anything
    //Any other datatype, the method will expect to return that datatype
    public int TotalDistancePerFuel()
    {
        Console.WriteLine("Current Fuel: " + _fuel + " This is the owner: " + _owner);
        Console.WriteLine($"Gallon Per Mile: {_gallonPerMile} This is the owner: {_owner}");

        Console.WriteLine("This is how many miles: " + _fuel/_gallonPerMile);

        //Return keyword is what the method will give back
        return _fuel/_gallonPerMile;
    }

    //Methods can also have parameters
    //Parameters are implemented by adding in datatypes inside of the parenthesis
    //The comma is used if a method needs more than 1 parameter
    public void Sum(int num1, int num2)
    {
        Console.WriteLine(num1+num2);
    }
    
    //This is a constructor
    //It is a special method that will run whenever you create an object
    //Mostly used to instantiate/set value to your fields or property
    public Car()
    {
        _color = "Blue";
        _fuel = 100;
        _gallonPerMile = 5;
        _owner = "Stephen";
    }

    //You can have more than 1 constructor and the parameter is used to pass information and change the data of the field/property
    public Car(string p_owner)
    {
        _owner = p_owner;
    }

    //This is a Property
    //Gives us the flexibility to check that the data being stored is correct, let only certain things access data, make things read or write only
    public string Owner 
    {
        //get keyword is this is how the data is going to be shared
        get {return _owner;}

        //set keyword is how you change the data that is being stored
        set {_owner=value;}
    }

    //Fuel can only hold numbers from 0 to 100
    public int Fuel
    {
        get {return _fuel;}

        //We changed the way data is stored by adding a constraint that only 0 to 100 can be stored in this field
        set 
        {
            if (value <= 100 && value >= 0)
            {
                _fuel = value;
            }
            else
            {
                _fuel = 100;
                Console.WriteLine("Fuel can only hold from 0 to 100");
            }
        }
    }

    //You can make properties that will act like fields by formatting your property to look like this
    //adding the private keyword next to get will make the property set only
    //adding the private keyword next to set will make the property get only
    public string Brand { get; set; }
}