import { Quiz } from './quiz';

/* 
    What is node?
        - nodejs is a runtime environment
        - think of nodejs equivalent to JRE in java
        - used to run javascript programs outside of the browser

    What is npm?
        - node package manager
        - allows us to import opens source javascript code into our project
        - we creatre a new npm project by typing "npm init -y"

    What is typescript?
        - typescript is a superset of javascript
        - .... anything javascript can do, you can do in typescript
            - but typescript has some extra features.
        - typescript is transpiled to javascript before it is ran in the browser

    Low level languages: are closer to the 1s and 0s of the machine. Something like assembly, bytecode, c would all be considered lower level languages   
    High level languages: are more abstracted away and generally easier to use. 
        
    Compiled vs Transpiled?
        - compiled is converting a high level language to a lower level language
        - transpiled is converting a high level language to another high level language

    Features of Typescript:
        - strongly typed
            - easier to debug due to compile time errors
        - achieve oop concepts in a more friendly way.
*/


// let [VARIABLE NAME] : [DATATYPE] = [VALUE];

/* 
    What are the datatypes of js?
        - number string null NAN boolean
    Additional datatypes in typescript:
        - void, enum, tuple, any
*/

let x : number = 5;
let str : string = "whatever the value is";


//you can restrict variables to multiple datatypes
let val : number | string = 5;
val = "Hello";


let arr : number[] = [1,2,3,4,5];
let arr2 : Array<number> = [1,2,3,4,5];


//tuple is basically a fixed size array with specific datatypes in each section
let tup : [Array<string>, number, boolean];
tup = [["Kevin", "Joshua", "Troy"], 56, false];


//enum is set of named constants
enum carStates{OFF=10, DRIVING, STOPPED, ACCELERATE};
console.log(carStates.DRIVING);



//functions
function func(val1 : number, val2 : number) : number {
    return val1 + val2;
}

const func2 = (val1 : number, val2 : number) : number => {
    return val1 + val2;
}

//What is a callback function?  
    // A Callback function is a function that is passed to another function that will eventuall be called in that function
function callbackExample(fctn){
    console.log("running some sort of logic")

    fctn();
}

callbackExample(() => {
    console.log("logic from callback function")
})

callbackExample(() => {
    console.log("some other logic being used")
})

callbackExample(function(){
    console.log("using normal function notation")
});



//interfaces
interface Criminal{
    name: string;

    method1(arg1 : string, arg2 : number);
}

class Villain implements Criminal{
    name: "Kevin";

    //? makes passing of values to parameters optional
    constructor(test?: string){

    }

    method1(arg1: string, arg2: number) {
        return arg1 + arg2;
    }

    /* 
        Access Modifiers of Typescript:
            - public - accessible anywhere (implicitly this)
            - protected - can be accessed between the class and subclasses
            - private - can be access within the class
    */
}

let vill : Villain = new Villain();



//this is how we will be utilizing interfaces in react (to define our models)
interface User{
    username: string;
    password: string;
    age: number;
}


let user : User = {
    username: "Kevin",
    password: "Childs",
    age: 40
}





//encapsulation
class Pet{
    
    constructor(private _name : string){

    }

    get name() : string {
        return this._name;
    }

    set name(n : string){
        this._name = n;
    }
}


let dog: Pet = new Pet("spike");

dog.name = "max";

console.log(dog.name);



//we can utilize the quiz class by importing the module
let quiz : Quiz = new Quiz();

quiz.grade = 100;

console.log(quiz.grade)


