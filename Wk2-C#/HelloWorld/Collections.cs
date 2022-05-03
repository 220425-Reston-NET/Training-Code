using System.Collections;

public class Collections
{
    //Array
    //Used to store a datatype and have fixed sizes
    //Syntax: datatype[] (nameOfVariable) = new (datatype)[(sizeOfArray)]
    int[] _numbersArray = new int[5];

    //Generic Collections
    //They are a collection that store specific datatypes
    //They have a dynamically changing size

    //List Collections
    //Zero-based index
    //Used to store a datatype and have dynamically changing size
    List<int> _numbersList = new List<int>();

    //HashSet Collections
    //There is no particular order to the elements it is not zero-based index (meaning you can't get specific elements or LINQ)
    //You cannot have duplicated elements, everything must be unique
    HashSet<int> _numbersHash = new HashSet<int>();

    //Dictionary Collections
    //Store information through key-value pairs
    //There is no particular order
    //Keys needs to be unique to be able to locate information
    //You can specify what datatype you want both the key and value to be
    Dictionary<string, int> _personAge = new Dictionary<string, int>();

    //Non-generic Collection
    //They are collection that doesn't need any datatype

    //ArrayList Collection
    ArrayList _numbersArrayList = new ArrayList();


    public void CollectionMain()
    {
        Console.WriteLine("===Array Demo===");
        //Allows us to set what tos tore in certain positions
        //0 1 2 3 4 - Zero-based index
        _numbersArray[0] = 3;
        _numbersArray[1] = 10;
        _numbersArray[2] = 100;

        //A way to go through an array
        //Foreach will iterate through all the of the elemnts of the array
        //Syntax: ((datatype) (nameOfVariable) in (nameOfArray))
        foreach(int element in _numbersArray)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("===List Demo===");
        _numbersList.Add(3);
        _numbersList.Add(10);
        _numbersList.Add(100);
        _numbersList.Add(100);

        // Console.WriteLine(_numbersList[1]);
        foreach (int element in _numbersList)
        {
            Console.WriteLine(element);
        }

        //For loop
        //sets a variable; some condition to check if it repeats again; increment/decrement of a variable
        for (int i = 0; i < _numbersList.Count; i++)
        {
            Console.WriteLine(_numbersList[i]);
        }

        //while loop
        int i2 = 0;
        while (i2 < _numbersList.Count)
        {
            Console.WriteLine(_numbersList[i2]);
            i2++;
        }

        Console.WriteLine("===Hash Demo===");
        _numbersHash.Add(3);
        _numbersHash.Add(10);
        _numbersHash.Add(100);
        _numbersHash.Add(100);

        foreach (int element in _numbersHash)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("===Dictionary Demo===");
        _personAge.Add("Chadel", 26);
        _personAge.Add("Troy", 31);
        _personAge.Add("Maaz", 24);

        Console.WriteLine(_personAge["Troy"]);

        Console.WriteLine("===ArrayList Demo===");
        _numbersArrayList.Add("Hello");
        _numbersArrayList.Add(10);
        _numbersArrayList.Add(12.03);
        _numbersArrayList.Add(true);
        
        foreach (object item in _numbersArrayList)
        {
            Console.WriteLine(item);
        }
    }
}