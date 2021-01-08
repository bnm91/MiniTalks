/*
    What about let (or const)
*/

var text = 'outside';
function logIt(){
    console.log(text);
    let text = 'inside';
};
logIt();

/*
    This time we get a ReferenceError instead of undefined? 
    Why? declarations made with let or const do not get hoisted


    NOTE:
    It seems that some people dispute this and claim that let and const do get hoisted
    but while var variables get initialized to "undefined" by default, let and const truly don't get initialized until done so in code
    Thus far, I've found no definitive answer on which of these explanations is exactly tecnically the correct one.
    The controversy even goes so far that the MDN and W3 pages on hoisting explicitly disagree on the subject
    For all reasonable purposes, it seems we can view let and const as not being hoisted b/c in practice they behave that way
*/


/*
    PS: Note that the below code outputs undefined
    
        var text = 'outside';
        function logIt(){
            let text;
            console.log(text);
            text = 'inside';
        };
        logIt();

*/