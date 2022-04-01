// https://www.typescriptlang.org/docs/handbook/release-notes/typescript-3-0.html#new-unknown-top-type
// https://mariusschulz.com/blog/the-unknown-type-in-typescript

/*
Unknown Type
A typescript "top type" or "universal super type" meaning every other type is assignable to it   
"Anything is assignable to unknown, but unknown isn't assignable to anything but itself and any without a type assertion or a control flow based narrowing"
Maintains type safety at compile time while allowing uncertainty before type-check can be done

Any Type
Also a top type.
Effectively allows you to use variable without type.
Kind of negates the Typescript elements of Typescript and returns to javascript style variables
An older version of the official typescript handbook describes it as "a powerful way to work with existing JavaScript, 
allowing you to gradually opt-in and opt-out of type checking during compilation."
*/

let unknownValue: unknown;
let anyValue: any;




// unknown vs any
let unknownValue1: unknown = unknownValue;
let unknownValue2: any = unknownValue;
let unknownValue3: boolean = unknownValue;  // Type 'unknown' is not assignable to type 'boolean'

let anyValue1: unknown = anyValue;
let anyValue2: any = anyValue;
let anyValue3: boolean = anyValue;

// unknown is type safe
unknownValue.foo.bar;   // Property 'foo' does not exist on type 'unknown'
unknownValue.trim();    // Property 'trim' does not exist on type 'unknown'
new unknownValue();     // This expression is not constructable. Type {} has no construct signatures
unknownValue++;         // An arithmetic operand must be of type 'any', 'number', 'bigint', or an enum type
unknownValue * 0;       // An arithmetic operand must be of type 'any', 'number', 'bigint', or an enum type

//any is not
anyValue.foo.bar;
anyValue.trim();




// with unknown, if you type check the unknown variable, it can then be used as if it had that type
if (typeof unknownValue === "function") {
    const functionName = unknownValue.name || "anonymous";  // Property 'name' does not exist on type unknown
}



unknownValue.toISOString();
if (unknownValue instanceof Date) {
    const date = unknownValue.toISOString();
}

// this even works with custom type checking functions 
function isNumberArray(value: unknown): value is number[] {
    return Array.isArray(value) && value.every(element => typeof element === "number");
}
const unknownTypedNumberArray: unknown = [1,2,3,4,5];
unknownTypedNumberArray.every(element => true);     // Property 'every' does not exist on type 'unknown'
if(isNumberArray(unknownTypedNumberArray)) {
    unknownTypedNumberArray.every(element => true);
}


function handleInput(input: unknown) {
    if(typeof input === 'string') {
        input = input.trim();
        return input.toUpperCase();
    }

    if (typeof input === 'number') {
        return input.toString();
    }
}


// It also works with type assertions using the "as" keyword
const unknownTypedString: unknown = "Hello World";
unknownTypedString.toUpperCase();   // Property 'toUpperCase' does not exist on type 'unknown'
const foo: string = unknownTypedString as string;
const bar = foo.toUpperCase();



// In an intersection everything absorbs unknown
type T00 = unknown & null; // null
type T01 = unknown & undefined; // undefined
type T03 = unknown & string; // string
type T04 = unknown & string[]; // string[]
type T05 = unknown & unknown; // unknown
type T06 = unknown & any; // any
// In a union an unknown absorbs everything
type T10 = unknown | null; // unknown
type T11 = unknown | undefined; // unknown
type T13 = unknown | string; // unknown
type T14 = unknown | string[]; // unknown
type T15 = unknown | unknown; // unknown
type T16 = unknown | any; // any



function fetchFromLocalStorage(data: string): Date {

}