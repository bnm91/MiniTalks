// Explanation
//  The key is how variable are passed to functions in javascript.  
//  Everything is passed by value in javascript.  
//  This can be confusing when it comes to reference-types, but since buttonNumber is a primitive we don't need to worry about that here.
//
//  Pass By Value:  
//  runtime creates a copy of the variable passed in as a parameter to be used in the scope of that function
//
//  vs
//
//  Pass By Reference:
//  The actual original variable is passed in.  The parameter name is merely an alias




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

function createClickFunction(buttonNumber) { // (3)
    return () => {
        console.log(types[buttonNumber]); // (4)
    };
}

for (var btnNum = 0; btnNum < types.length; btnNum++) { // (1)
    buttonArray[btnNum].onClick = createClickFunction(btnNum); // (2)
}

buttonArray[0].onClick();  // (5)
console.dir(buttonArray[0].onClick);
buttonArray[1].onClick();
console.dir(buttonArray[1].onClick);
buttonArray[2].onClick();
console.dir(buttonArray[2].onClick);



//  Because buttonNumber is being passed (by value) to createClickFunction, javascript creates a copy of buttonNumber to be
//  used within the scope of that function.  Each time that createClickFunction is executed, javascript creates a unique copy
//  of buttonNumber to be used only in that scope.  In this way, we "freeze" the buttonNumber for each onClick function instead of 
//  letting each function reference the same btnNum variable.

//  Broken down futher
//
//  (1)
//  our loop variable btnNum currently has the value 0
//
//  (2)
//  We call our "function that creates a function" passing in btnNum, which at this time = 0 [see (1)]
//
//  (3)
//  When we pass in our parameter to createClickFunction, javascript secretly creates a new variable
//  Let's call this variable buttonNumber_0.  This variable is equal to 0, the value of btnNum at the time it was passed in
//  and will only be used for this single call of createClickFunction.
//
//  (4)
//  The function outputted by createClickFunction is an anonymous function but to illustrate, let's pretend it has a name:
//  btn0OnClickFunction
//  If we were to imagine that javascript is taking notes on the side and writes down a hardcoded version of this function
//  to use later, it would look like this:
//  const buttonNumber_0 = 0;
//  function btn0OnClickFunction() {
//        console.log(types[buttonNumber_0]);
//  }
//
//  (5)
//  When we execute OnClick for button0, it executes the function we cretaed in steps (3) and (4), 
//  using the variable buttonNumber_0 that was secretly created in step (3) and that equals 0.
//  How do we even have access to our "frozen" button number buttonNumber_0? Closures

