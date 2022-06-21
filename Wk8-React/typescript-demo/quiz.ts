/* 
    a keyterm in typescript is module...
        - a module refers to a small unit of independent reusable code
        - when you use the export keyword on a class or function, it becomes a module
*/

class Quiz{
    questionNum : number;
    grade : number;
}

export { Quiz };