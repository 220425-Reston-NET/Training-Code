# Introduction to .NET 6.0
* It is a free, open-souce development platform for a variety of applications (Games, websites, console, etc)
* Essentially, it is a collection of languages and libraries that can work together to build many different types of applications
## Different types of open-source developer platform
* They decided to group certain functionalities with different names in .NET
1. .NET 6.0
    * The one you have right now
    * It supports the most types of apps and platforms since it is the combination of both .NET Core and .NET Framework
2. .NET Core
    * Just the older version of .NET 6.0
3. .NET Framework
    * It is used to exclusively create windows-only desktop applications
## What is C#?
* It is an object-oriented and type-safe programming language
    * Object-oriented means everythign is based on objects and classes and the relationships between them
    * Type-safe meaning once you set a datatype you can't change the datatype (unless you use certain techniques to do it)

# What is Object-Oriented programming?
* It is a methodology we use to design our programs just using classes and objects
* It makes it a lot easier to develop and maintain your project as it gets bigger
## Classes
* They are templates that are used to create objects and define the object's functions and current state (essentially what information they currently store)
## Objects
* It is any entity that has a state and behavior
* They are made from classes and will copy whatever state and behavior the class has defined
## Overall
* Classes are blueprints and Objects is the actual object from the blueprint
* Ex: 
    A blueprint of a car, tells you how to make a car but it isn't the car itself (The Class)
    The multiple cars you make from same blueprint (The Objects of that Class)

# DataTypes
* We can use datatypes to structure what kind of information we are storing and tell the program how we intend to use that data
## Value Types
* They are datatypes that stores value directly and not a reference to where the value is stored
* They are stored in the **stack** and not the heap
* Stack is always faster to retrieve data than heap
* Every value type has a set of memory set aside for it to occupy (Ex: int can only store 32-bits while a double can store 64-bits) and stack memory is all about structure for efficiency and how data cannot be dynamically changing in size
* Ex: int, double, char, bool, float, etc.
    There are special value types:
    * Structs - like a class but gets stored in the stack for memory retrieval efficiency 
    * Enums - defines a set of named integral constants
## Reference Types
* They are datatypes that are stored in the heap and reference variables that are stored in the stack
* Think of reference variables as having the address of a house since an address only holds the info on where the house is and not the actual house itself
* When you declare a variable of a reference type and not have it point to anything in the beginning, it will have a null value
    * Null in the coding world means lack of value or there isn't any value at all
* Reference variables are stored in the stack while the actual object itself is stored in the heap
* Why the heap? since memory in the heap can be dynamically changing
* Ex: classes, arrays, interfaces, strings, etc.

# What happens when you run your code?
* Well the computer doesn't understand english language and the keywords we have written in our source code (source codes are just )

# Arrays
* Used to store a datatype and have fixed sizes
* Zero-based index
    * 0 is the starting position of the array
* Other arrays you can make:
    * Multidimensional arrays - int[,] ex = new int[4,2]; would create
    [ [0, 0],
      [0, 0],
      [0, 0],
      [0, 0] ]
    * Jagged arrays - arrays inside of an array are different sizes
    [ [0, 0, 0], 
      [0, 0],
      [0, 0, 0],
      [0, 0 , 0, 0]
    ]
# Collections
* It is a data structure that can hold many values
* All collection has methods to add, remove, or find items since they all inherit from IEnumerable Interface
* In C#, there are two major types of collections: Generic and Non-generic
## Generic
* They are collections that store specific datatype
* The "T" you see in documentation is where you put what data type that collection will hold
### List
* Zero-based index
* Used to store a datatype and have dynamically changing sizes
* The most generic collection that is like an array but doesn't have a fixed size
### HashSet
* There is no particular order to the elements (Not zero-based index)
    * It is harder to find specific elements unless you use LINQ (that's later on)
* Every element is unique (Cannot have duplicated elements)
* Useful since you can perform set operations on two HashSets
* Example of set operations:
    * UnionWith - Lets you combine two Hashsets
    * ExceptWith - Substracts a Hashset from another Hashset
    * etc.
### Dictionary
* Stores info through key-value pairs
* There is also no particular order
* You can specify what datatype you want both the key and value to be
* Useful if you want to find specific information if you know the key
    * Think about your contacts, to find someone's phone number (Value) you just have to search for the person's name (Key) instead of trying to figure out what position that person might be located in like a List collection or an Array
### Other Generic
* You do the research on those two other collections
* Try using them in your code to understand what they do
* Queue - FIFO
* Stack - LIFO
## Non-Generic
* They are collections that can store multiple datatypes
* You don't give it any datatype
* Since C# is type-safe language how is this possible?
* Every class we made and any datatype in C# implicitly inherits Object class
    * Inheritance will make more sense once we talk about Object-Oriented Pillars
* Basically any datatype we put inside of a non-generic collection will be converted into an Object class rather than the datatype itself which can give a massive drawback
    * Can't add numerical datatypes anymore
    * Can't use specific methods from a class
    * etc.
### ArrayList
* Works the same as a List but it is non-generic version of it

# Conversion
* C# is statically typed at compiled time. Meaning after a variable is declared, it cannot be declared again.
* However, it is possible to change the variable type
## Implicit Conversion
* Generally, it is when you can convert the type without any data loss
* Mostly used with numerical datatypes
* No special syntax needed to write and compiler will do it for you
* Ex: converting an int into a double
## Explicit Conversion
* If there is a risk of losing information, you must perform a **Cast**
* Special syntax is needed to write to tell the compiler to do it anyway
* Casting is denoted with (datatype)
* Convert class is useful for converting a string datatype into another datatype

# Serialization
* The process of converting your objects into a stream of bytes (101001010) or a JSON file or an XML file for storage or transfer
* Helpful to store information that you want to persist even if you close down your program since it will be stored in your harddrive
    * Later in the program, we will use JSON to also send information between multiple computers/servers
* Two popular types of way to serialize information:
    1. JSON - JavaScript Object Notation (most popular one and easiest to understand)
    2.2 XML - eXtensible Markup Language (uses tags to define what the information is being sent)

# Exceptions
* An exception is an event that occurs during the execution of a program that distrupts the normal flow of instructions
    * Horrible to encounter when presenting your program (When it is expected to work perfectly fine)
    * Great when trying to find bugs in your program
* They are not Errors!
## Errors
* A serious problem that for the most part cannot be handled by the developer
    * They are fatal to the program at runtime
    * Ex: A stack overflow error and that usually occurs when your computer has run out of memory to store information
* 3 types of errors
    * Usage error - error in your program logic and can be solve by modifying/restructuring your code
    * Program Error - run-time error that cannot be avoided even with a bug-free code (Ex: Your SDK is corrupt and can't compile or translate it to machine code properly)
    * System Failures - run-time error that cannot be handled programmatically in a meaninful way (Ex: your ram hardware is faulty)
## Exception Handling
* Using a try-catch block and optionally finally block
* If you know the block of code you will run will have a risk of throwing an exception, you should put it in the try block
* The catch block will then "catch" that exception and will run instead its block of code
* Optionally, you can add a finally block that will run regardless if your code throws an exception or not
    * Mostly used to clean up any resources you used in the try blcok
## Throwing Exception
* You can throw an exception yourself in your code by using the throw keyword
* Useful for enforcing certain rules/logic in your program
## Exception Heirarchy
* Certain exceptions are more specific than other exceptions
* General rule is the most specific exception should be the very first catch block and the least specific exception is at the very last catch block
    * Why? Well if you made the least specific the first catch block then it will always run if any exception is thrown making your other catch blocks useless
