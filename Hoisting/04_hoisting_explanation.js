/*
    So, why is text undeclared by the time console.log gets called?
    It's declared and assigned on the very first line and the re-declaration/assignment doesn't happen until after console.log... right?
    That's true of the code as written.  However, javascript has it's secrets...

    Hoisting
    https://www.w3schools.com/js/js_hoisting.asp
    In javascript, hoisting refers to the fact that variable and function declarations are put into memory during the compile phase
    This gives the impression of the variable declarations being physically "hoisted" to the top of their scope
    https://developer.mozilla.org/en-US/docs/Glossary/Hoisting
    However, only declarations are hoisted -- not assignments
    (Sidebar: Since javascript allows initialization w/o declaration ie num = 6 instead of var num = 6, 
        it can appear as if var (and const, and let) cause the hositing)

    More on phases of javascript execution here under "how is javascript code interpreted"
    https://medium.com/javascript-in-plain-english/how-hoisting-works-with-let-and-const-in-javascript-725616df7085
    and here
    https://medium.com/@happymishra66/execution-context-in-javascript-319dd72e8e2c
    
*/


// Let's look at some code that represents what is actually happening in our example
var text = 'outside';
function logIt(){
    var text; // hoisted declaration of text w/in this scope
    console.log(text);
    text = 'inside';  //assignment is not hoisted
};
logIt();


/*
    Written out this way it becomes much more clear why the code outputs "undefined"
    The variable text is re-declared in the function scope.  Due to hoisting this declaration happens before any other code is executed
    So on line 23, text has been declared but not assigned in this scope ==> undefined
*/