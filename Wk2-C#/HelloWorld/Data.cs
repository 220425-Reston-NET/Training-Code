namespace Day5
{
    public class Data
    {
        static List<string> _shoppingCart = new List<string>();

        public static void DataMain()
        {
            _shoppingCart.Add("Mouse");
            _shoppingCart.Add("Keyboard");
            _shoppingCart.Add("Laptop");

            Console.Clear();
            Console.WriteLine("===Data Demo===");
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("What can I do for you?");
                Console.WriteLine("1 - Remove item from the cart");
                Console.WriteLine("2 - Search for item in the cart");
                Console.WriteLine("3 - Exit");

                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    //Logic to remove
                    Console.WriteLine("===========Shopping Cart==========");
                    foreach (string item in _shoppingCart)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("=============================");
                    Console.WriteLine("Can you please tell me the name of the item you want to remove?");

                    string item2 = Console.ReadLine();

                    if (_shoppingCart.Remove(item2))
                    {
                        Console.WriteLine("Successfully delete item!");  
                    }
                    else
                    {
                        Console.WriteLine("Failed to delete item. It doesn't exist");
                    }
                }   
                else if (answer == "2")
                {
                    //Logic to search
                    Console.WriteLine("Can you please tell me the name of the item you want to search?");

                    string item3 = Console.ReadLine();

                    bool match = false;
                    foreach (string item in _shoppingCart)
                    {
                        if (item3 == item)
                        {
                            match = true;
                        }
                    }

                    if (match)
                    {
                        Console.WriteLine("Item was found");

                    }
                    else
                    {
                        Console.WriteLine("Item was not found");
                    }
                }
                else if (answer == "3")
                {
                    repeat = false;
                }
                else
                {
                    //Person didn't choose any of the available option
                    Console.WriteLine("Please enter a valid response");
                }

            }
        }
    }

}