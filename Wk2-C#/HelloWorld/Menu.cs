public class Menu
{
    private string _name;
    public string Name
    {
        get{ return _name;}
        set{ _name = value;}
    } 
    private int _mousePrice;
    private int _keyboardPrice;
    private int _phonePrice;
    //Another way to make a property that doesn't require a field attached to it.
    public int LaptopPrice { get; set; }
    private int _totalPrice; //Saving the total price of what the user saved.
    public int TotalPrice
    {
        get{ return _totalPrice;}
        set{ _totalPrice = value;}
    }

    public Menu()
    {
        _name = "Stephen";
        _mousePrice = 10;
        _keyboardPrice = 99;
        _phonePrice = 1000;
        LaptopPrice = 2000;
    }

    //This method will greet the user
    public void GreetUser()
    {
        Console.Clear();
        Console.WriteLine("Hello " + _name + "! What can I do for you?");
        Console.WriteLine("1. Buy an item");
        Console.WriteLine("2. Checkout");
    }

    //This method will buy something
    public void BuyItem()
    {
        Console.WriteLine("1 - mouse $" + _mousePrice);
        Console.WriteLine("2 - keyboard $" + _keyboardPrice);
        Console.WriteLine("3 - phone $" + _phonePrice);
        Console.WriteLine("4 - laptop $" + LaptopPrice);
        string answer = Console.ReadLine();
        if (answer == "1")
        {
            _totalPrice += _mousePrice;
        }
        else if (answer == "2")
        {
            _totalPrice += _keyboardPrice;
        }
        else if(answer == "3")
        {
            _totalPrice += _phonePrice;
        }
        else if(answer == "4")
        {
            _totalPrice += LaptopPrice;
        }
        Console.WriteLine("Your current total is: " + _totalPrice);
    }
}