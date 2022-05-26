# What we have been doing so far
* A monolithic architecture
    * Meaning the frontend (anything visual to the user and the backend (the actual logic that does the function) are tightly coupled)
        * Tightly coupled just means if you update one thing, it breaks another thing since they are highly dependent on one another
        * So in our context, if we update something in BL, DL, and Model (the backend), there is a good chance it will break something in our UI (the frontend)
## Pros
* Prototyping an application and getting something working right away
* Simple applications or working on your own 

## Cons
* Horrible for scaling the application
* Impossible to develop backend and frontend separately

# Service Oriented Architecture (SOA) Introduction
* A style of software design where services are provided to the other components by application components, through a communication protocol over a network
* Intuitive definition: We are decoupling backend and frontend and a communication protocol (can be HTTP, HTTPS, SMTP, etc.) to communicate between the two entities via the internet
## What are Services?
* They are responsible for sending and receiving data
* They provide some sort of functionality that clients might want 
    * like a service in the real world (i.e. you go to a barber place to get a haircut service)
* They are independent of platforms and programming language
    * Meaning you can create one using any programming language and once deployed, any programming language can use it
    * Ex: Creating a service with C# and having a java application use it
## SOA principles
* Many rules that you must follow to achieve SOA
### Standard Service Contract
* Must have a descritpion on what the service is about
* This makes it easier for a client to understand what the service does
### Loose Coupling
* Less dependency on each other (frontend and backend)
* So, if the service functionality changes at any point in time, it should (must) not break the client application or stop it from working
### Service Abstraction
* Services hides the logic
* You only know what the service does and how to use it but never on how they implemented the application
### Service Reusability
* Logic was made in a way that it can be re-used as many times as the client wants
* Other clients can also use your service at the same time without any issues
### Service Statelessness
* Service should not withhold information from one state to the other
* Ex: Any data used to do a functionality should be gone after doing the functionality
## Pros
* Frontend and backend can be developed separately without any problem
* A lot easier to scale
* Platform independent
## Cons
* High investment cost
    * You need two separate teams to do either frontend and backend
* As with adding more teams, communication can become an issue
    * Since frontend and backend are being developed separately they might not have the same idea on doing a functionality (which you might experience once you start working in teams!)

# 

# HTTP/HTTPS
* Hyper Text Transfer Protocol (Secured)
* The protocol that both computers have to follow in order to understand/communicate with each other and work together to display a nice looking website in your browser, register an account, login, etc.

## HTTP Life Cycle
* An overview of what happens if you put in a url in your browser and out comes a website
1. Client (your browser) will send a request (the url you sent)
2. The server will receive that request and will do some processes
3. The server will send an appropriate response (html, css, js, json, etc.)
4. The client will receive the response and the browser will process that response

## Domain Name System (DNS)
* It is essentially a directory of names and ip address
* It translates a pretty loorking name of a website (www.google.com) into some numerical ip address ranging from (0.0.0.0 - 255.255.255.255) for locating the right server and to process the http request
* Main reason is the same reason why you save people's phone number in contact in a form of a name instead of just their phone number
    * It is easier to remember!

## HTTP Verbs/Methods
* Describes what action the client wants the server to perform on a given resource  
    * What is a resource? Anything the server is providing counts as a resource
* Common Verb
    * Get - Used to retrieve data from the server
    * Post - Used to submit data to the server
    * Put - Used to update/replace data on the server
    * Delete - Used to delete existing data on the server
    * Head - It is like the get method but it will only give you the header (metadata so no response body)

## HTTP status code
* Gives the result of the HTTP request
* 1XX - informational
* 2XX - Success
* 3XX - Redirection
* 4XX - Client error
* 5XX - Server error

# Moar HTTP
* You don't have to memorize it for QC but it will make HTTP as a whole makes more sense as I explain other topics

## HTTP Request
* It is essentially what the client sents 
* It will tell what HTTP verb the request will be all about (either GET, POST, PUT, etc.)
* It will tell what kind of actual data the client is trying to sent (in a JSON format)
* It has a bunch of other useful metadata things you don't need to know like ip addresses, urls, etc. things that might be useful for debugging purposes

## HTTP Response
* It is essentailly what the server sends back to the client
* It will give a **status code** if it was successful or not
* More metadata stuff for debugging purposes
* What kind of data the server is trying to sent to the client (in a JSON format)

# ASP.NET
* Another framework included in our .NET 6 that specializes in creating web application in either C# or VB
* For us, we will just use it to create a restful web api instead of including the frontend tech just yet

## Controller
* Their main responsiblity is to handle HTTP requests and formulate an appropriate HTTP response based on what functionality it is trying to achieve
* This is why the first thing we do to define an action (basically a method inside of controller) is to tell it what HTTP verb it should handle
    * Ex: [HttpGet] - no surprises handles http get requests
* You also specify the actual route/endpoints the client needs to use for specific functionalities inside of your controller
    * Ex: [Route(api/[controller])] - the endpoint has to be (website name).com/api/(The controller name)
* It will call on the appropriate business logic to process what the clients wants to do
    * You essentially replaced the console project to instead just have the web api project as the starting point

## Model Binding
* It is a way to bind data (JSON objects) coming from HTTP request to be automatically mapped into a C# model
* Remember how HTTP transfers information via JSON files? Well ASP.NET can automatically map that JSON object into a C# object
    * So instead of manually mapping it like our DL, it does it for us
    * Just need to know the fancy name that does that operation which is model binding
* Ex: controller action([FromBody] someModel p_model)
    * Mapping whatever JSON file you got into a "someModel" object that C# understands
* Model binding can also do it from C# object into JSON object
    * When we return a C# object in an action, it automatically creates a JSON object that gets put into an HTTP response

## Middleware
* Allows ASP.NET to know where to take the user's http request
    * In our case, which controller and which action inside of the controller should the http request go to
* It uses **routing middleware** to be able to find the appropriate controller and then the appropriate action within the controller to handle the request
    * It is the middleman between the asp.net app and the client
    * It also handled http responses and routes that information back to the client

## Filters
* They are used to create your own custom logic (your own code) if a certain event has happened
    * Applies to most filters but not all
### Authorization
* Used to determine whether the user is authorized for the request
* This will run first
### Resource
* Used for logging, caching, and other resource related operations
* You can configure whether to run the resource filter first or after an action
* Ex: OnResourceExecuting filter will run your custom code first before doing any model binding operations
* For optimization purposes
* Runs after Authorization
### Action
* Will perform your custom code after or before a controller action
### Exception
* Will perform your custom code after or before an exception
### Result
* Will perform some code after or before the execution of giving a view or IActionResult

## Swagger (OpenAPI)
* Swagger is a tool pre-built in our ASP.NET project with the sole purpose of checking if our rest api is definitely working
* As you have guess, we don't really have a console app so we can visually see that our app is working so they created swagger just for the purpose
* It will show you every action inside of a controller and also test them
    * It can check what http response body it gave
    * It can check what http request the client needs to give to make it work and so on
* Really useful debugging tool for our api

## ASP.NET Caching
* Storing information in your app and just recalling that information rather than doing another operation on your database
* Useful if you expect to use that information multiple times to do a single operation
* Useful if your function does a complex sql operation to get that data that takes time and to store that information to call on instead
* Might cause problems if database gets updated and using the cache information will be outdated

# LINQ
* Language-Integrated Query
* It is a query language that is very similar to our SQL but we can use it in C# or VB
* So like any query langauge, it is incredibly useful for filtering/acquiring/aggregating data
* Very useful documentation click [here](https://www.tutorialsteacher.com/linq)
## Method syntax
* It is more like C# in that you use methods to perform the queries
* For simeple filtering, I would use method syntaxes
## Query syntax
* It is more like SQL in that you create a statement-like operation using keywords
* I would use joins with query syntaxes since it is easier to understand