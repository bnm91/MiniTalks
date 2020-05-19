var fakeButton0 = {
    name: 'btn0'
};
var fakeButton1 = {
    name: 'btn1'
};
var fakeButton2 = {
    name: 'btn2'
};

const buttonArray = [fakeButton0, fakeButton1, fakeButton2];
const types = ['exchange', 'sharepoint', 'groups']

for (let btnNum = 0; btnNum < types.length; btnNum++) {
    buttonArray[btnNum].onClick = () => {
        console.log(types[btnNum]);
    }
}

buttonArray[0].onClick(); 
buttonArray[1].onClick();
buttonArray[2].onClick();


// As of ES2016, if we use let when declaring the loop variable, all of this just works without the adding "function that creates a function"
// Why?


// TL;DR: ECMAScript 2016 specifies that a loop variable declared with "let" creates a new instance of that variable each  iteration 

// The let keyword means the variable is mutable and block scoped (scoped between two curly brackets)
// Knowing that, it didn't make intuitive sense to me that just because the variable is block scoped,
// a new instance would be created each loop.  So I really wanted to understand why that was true.
//
// Turns out, it's kind of just a choice they made for ECMAScript 2016.  Loops are weird wrt "blocks" because is the actual looping code part of the block? ie:   for (let i = 0; i < num; i++)
// http://www.ecma-international.org/ecma-262/7.0/index.html#sec-createperiterationenvironment
//
// Here's a good stackoverflow post that explains in in plainer English I could actually understand
// https://stackoverflow.com/questions/30899612/explanation-of-let-and-block-scoping-with-for-loops/30900289#30900289
//
// So the real reason is that it's just "how it works" in ES16 --  a decision was made and that's how it is
// You can begin to understand why a decision had to be made one way or other if you start to think how you would deal
// with a block-scoped variable in a loop.  The block is really just what's between the curly braces? But then how does the actual
// looping mechanism use that?  One solution is to create a new copy each iteration and apparently that's what they did
//
// NOTE: apparently early versions of Google's V8 javascript engine had serious performance issues related to this that have since
//          been optimized away