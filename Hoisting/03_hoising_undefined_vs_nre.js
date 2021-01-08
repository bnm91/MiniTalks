var a;
console.log("a is " + a);
console.log("b is " + b);

/*
    Result:
    a is undefined
    > Uncaught ReferencEerror: b is not defined


    a is not assigned ==> undefined
    b is not declared (and not assigned) ==> reference error
*/