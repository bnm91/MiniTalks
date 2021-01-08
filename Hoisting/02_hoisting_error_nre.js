/*
    Notice, it's undefined, *not* a reference error.
    Why?
    The code below shows that we can get a reference error if we want one.
*/

function logIt(){
    console.log(text);
};
logIt();


/*
    What does this mean?
    In our original example, the variable text was "undefined"
    This implies the variable was declared but not assigned!
    See 03 for proof
*/