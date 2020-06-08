import { of } from "rxjs";

// use of operator to create observable that pushes 1, then 2, then 3
let observable = of(1,2,3); 

// subscribe to that observable with an observer that prints the value when received
observable.subscribe(x => console.log(x));