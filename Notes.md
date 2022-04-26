# Scripting Fundamentals
## Command Line Interface (CLI)
* It is an interface (basically mean something you can mess with) that interacts with your computer to do certain operations
* It can make folders, open folders, or do a plethora of other functionalities
* So why is this important when you can do the same operations (for the most part) with a file explorer?
    * Well in the coding world, there is no such thing as a pretty UI
    * Everyone is more focused on the functionality than adding a nice graphical representation of it
* So get ready to get used to seeing a terminal and messing with it. Down the line, we will add more functionalities to our basic CLI to do cool things
* You will also see that most of the common problems you'll experience is most likely or not the wrong usage of the terminal

## Shell
* While the CLI is how the user interacts with the computer, a shell is essentially the brain
* It will look at what the user inputs on the CLI and interpret it to do the operations
* To be able to understand what the user is trying to ask it to do, it has pre-made keywords that the user can do
* Want to change directory? Well the user needs to type "cd" on the CLI to undersand that you want to change directory. Anything else you type it may not understand it and shell will also let you know that it didn't understand it
### Bash
* It is Unix shell that provides the user extra commands that doesn't exist in other shell such as command prompt
* Essentially command prompt was made for Window OS while Git bash was made for Unix/Linux based OS

## Shell Commands
* Help - shows all the potential commands you can use in the terminal 
    * pretty universal that any added shell commands we get from installing a library, SDK, or framework will have a help command to show their specific commands
* Pwd - shows the current directory the terminal is in
* Ls - Lists all the files inside of that directory 
* Cd - Changes the current directory of the terminal is in
* Mkdir - Makes a directory
* Echo - Displays text to the terminal
* Touch - Updates the time stamp of the file
    * Can also be used to create a file
* Grep - Searches for patterns in a file
    * Think of the feature (CTRL+F) that finds certain words in what application you are using
* Cat - concatenate/combine two files together
    * If they are text files, it will combine the text files together and show both their contents
* Which - Locates the path file of your commands in the terminal
* Find - Finds certain directories of files
    * Think of the search bar in your file explorer that finds certain filenames
* Nano - Allows us to edit files
    * Think of notepad
* Read - Will ask the user for some input and store it inside of a variable

