public class ConversionsTwo
{
    //General description for static keyword (non-access modifier)
    //It belongs to the class
    // public static int test = 10;
    public static void ConversionTwoMain()
    {
        int fuel = 10;
        double fuel2 = 10.381;

        Console.WriteLine("===Conversion Two Demo===");
        //Old way without User-defined conversion
        // Car2 carObj = new Car2();
        // carObj.Fuel = fuel;

        Car2 carObj = fuel;
        Console.WriteLine(carObj.Fuel);

        string name = "Stephen";

        Car2 carObj2 = (Car2)name;

        Car2 carObj3 = fuel2;

        //Value type
        //You have the value directly
        int num = 123;

        //Boxing example
        //When a value type gets converted into a reference type
        //It is an implicit conversion
        object obj = num;
        Console.WriteLine(obj);

        //Unboxing example
        //When you extract the value type from the object and just get the value directly
        //Explicit conversion
        int num2 = (int)obj;
        Console.WriteLine(num2);
    }
}

public class Car2 
{
    public string Owner { get; set; }
    public double Fuel { get; set; }

    //User-defined conversion
    //Allows us to create a class to be able to convert from some other datatype
    public static implicit operator Car2(int p_fuel)
    {
        return new Car2()
        {
            Fuel = p_fuel
        };
    }
    public static implicit operator Car2(double p_fuel)
    {
        return new Car2()
        {
            Fuel = p_fuel
        };
    }

    //Explicit Conversion
    public static explicit operator Car2(string p_owner)
    {
        return new Car2()
        {
            Owner = p_owner
        };
    }

}