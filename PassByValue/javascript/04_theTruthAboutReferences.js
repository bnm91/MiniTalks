// All of javascript is pass-by-value, but sometimes that value is a reference
// This gives the appearance of being sometimes pass by reference

//https://stackoverflow.com/questions/518000/is-javascript-a-pass-by-reference-or-pass-by-value-language
//  Look at the first response and then understand it through the context of Tim Goodman's comment
//  Everything in Javascript is pass-by-value but sometimes the value being passed is a reference
//  Note: I've changed the order of the obj1 and obj2 because I think that order flows better for learning

function changeStuff(num, obj1, obj2)
{
    num = num * 10;
    obj1 = {item: "changed"};
    obj2.item = "changed";
}

var num = 10;
var obj1 = {item: "unchanged"};
var obj2 = {item: "unchanged"};

changeStuff(num, obj1, obj2);

console.log(num);       // 10
console.log(obj1.item); // unchanged
console.log(obj2.item); // changed



//num
//  this is a primitive.  Easy to understand from what we just learned
//  the num that is getting multiplied is actually a copy, think parameter a as equal to num_copy
//  the original variable num is not touched by changeStuff


//  As review, a reference is just an address to another location in javascript's memory.  
//  It's not important how this is actually implemented in javascript but we can think of it as a number that points
//  to a location in memory, like a street address house number

//obj1
//  this is an object.  so the parameter obj2 is a new variable is a reference to an object.
//  let's call this reference obj2_copy.  so when changeStuff exectues obj2 = {item: "changed"},
//  it's really reassigning obj2_copy to be a reference to a new location in memory where the 
//  object {item: "changed"} is stored.
//  It's take our copy of the house address, and changed it to someone else's address.
//  When obj2 gets used in the future, obj2 is still a reference to the OLD location in memory where
//  the original object {item: "unchanged"} is stored.  obj2 is still using the old house address

//obj2
//  this is an object.  So the parameter obj1 is a new variable which is a reference to an object.
//  let's call this reference obj1_copy.  So when changeStuff executes obj1.item = "changed",
//  it's really executing obj1_copy.item = "changed".  So javascript is using that reference, looking up 
//  that object in memory, and altering it's item property at that location in memory.  It's got the same
//  house address, going to that same house, and changing something inside.
//  
//  When obj1 gets used in the future, obj1 is still a reference to the same location in memory, 
//  but now there is a new value at that location -- item has changed