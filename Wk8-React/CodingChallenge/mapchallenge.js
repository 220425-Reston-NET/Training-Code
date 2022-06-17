let arr = ["Kevin", "Steve", "Nikki"];

//use the map array method to convert to ["evinKay", "teveSay", "ikkiNay"]


/* 
    1. we need to understand the map array method
        - map allows us to transform values in one array and put it in a new array
    2. string manipulation
*/

let str = "Kevin";


/* 
    i need to figure out how to add the first letter to the end of the word
        - i need to know how to get a one character from a word
        - i need to know how to append it to the end
    KevinK
    i need to figure out how to remove a character from a word
    evinK
    i need to add ay to the end
    evinKay
*/

let pigLatinArr = arr.map((name) => {
    let firsCharacter = name.charAt(0);
    name = name.concat(firsCharacter + "ay");
    name = name.substring(1);

    return name;
});


/* let firsChar = str.charAt(0);
str = str.concat(firsChar + "ay");
str = str.substring(1);

console.log(str); */

console.log(pigLatinArr);


