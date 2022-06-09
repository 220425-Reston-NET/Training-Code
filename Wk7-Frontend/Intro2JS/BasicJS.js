function CreatingAnObjectFunction() {
    let dog = {
        color:"Black",
        name:"Minnie",
        size: 10,

        speak: function(speak) {
            console.log("Bark Bark!");
            console.log(speak);
        },
        howBig: function() {
            //this is a keyword that specifically references the property inside of the object/class
            console.log("This dog is " + this.size);
        }
    }

    let size = 129803;
    console.log(dog);
    //Will display undefined when speak parameter was used in the function since it never had a value
    dog.speak();

    dog.speak("hello");
    console.log(dog.color);
    dog.howBig();
}

function CreatingClassesFunction() {
    //There is no such thing as access modifiers in JS
    class Animal {
        // name = "Default"

        //Constructor is the same as a constructor in C#. In that, it will run this particular lines of code the moment you try to create an object out of that class
        constructor(name){

            //This is a way for JS to create a field in a class and put in the value of whatever the person wrote
            this.name = name;
        }

        //This is a method and acts like a method in C#. 
        //Main difference is a method is inside a class while a function is not
        speak(){
            console.log("Hello");
        }
    }

    //Inheritance works the same as C# but uses the extends keyword
    class Dog extends Animal {
        //public field
        color = "Black";

        //private field
        //Useful for encapsulation
        //Adding a # will make that field into a private field
        #size = 10;

        //Method overriding works just fine in JS
        speak(){
            console.log("Bark Bark");
        }

        //Method overloading does not work well in JS
        //Any similar method name no matter their parameters will get replaced
        // speak(sentence){
        //     console.log(sentence);
        // }

        //Abstraction is not easily implemented at the moment

        //Very similar to how C# does properties
        //There is no such thing as C# properties in JS
        //Getter
        get Size(){
            return this.#size;
        }

        //Setter
        set Size(p_size){
            this.#size = p_size;
        }

    }

    let animal1 = new Animal("Stephen");
    console.log(animal1);
    animal1.speak();

    let dog1 = new Dog("Minnie");
    console.log(dog1.name);
    dog1.speak();
    dog1.speak("Hello this is a talking dog")

    console.log(dog1.color);
    dog1.Size = 100;
    console.log(dog1.Size);
}

function DOMFunction() {
    /*
        Biggest thing as to why JS is used in the frontend (To dynamically change our website)
        In an HTML you have a bunch of tags to structure a website
        At the back, HTML also converts that structure into a "tree" of object model for JS to access/manipulate

        TDLR: DOM lets us dynamically change the elements inside an HTML doc
    */

    //Creates a span element in JS
    let spanElement = document.createElement("span");
    spanElement.innerHTML = "You just created a span";

    //Where should you put the span element
    document.querySelector(".addElementHere").appendChild(spanElement);

    document.getElementById("DOMHeading").style.color = "red";
}