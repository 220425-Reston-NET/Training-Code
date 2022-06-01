//Interface is a contract that will specify that whatever classes that inherits this interface must have these methods
public interface IMenu
{
    //Display method will write to the terminal the answer choices the user can pick
    //It will also show what menu they are currently in
    void Display();

    //YourChoice method will grab the user feedback and return what menu should be displayed
    string YourChoice();
}