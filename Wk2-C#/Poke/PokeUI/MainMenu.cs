namespace PokeUI
{
    public class MainMenu
    {
        //This method will display things in your terminal that will show what the user can do
        public void Display()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What can I do for you?");
            Console.WriteLine("[1] - Add a new pokemon");
            Console.WriteLine("[0] - Exit");
        }

        //This method will ask the user what to do
        public string YourChoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                //Logic add pokemon
                return "AddPokemon";
            }
            else if (userInput == "0")
            {
                //Logic to exit
                return "Exit";
            }
            else
            {
                Console.WriteLine("Please input a valid response");
                return "MainMenu";
            }
        }
    }
}