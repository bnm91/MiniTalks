// npm install rxjs
// follow this: https://code.visualstudio.com/docs/typescript/typescript-compiling
// NOTE: set up tsconfig.json to use es2016 (link above specifies es5 which is too old)
// If you already ran the ObservableBasics.ts you may have to change your launch.json to run this instead


import { Observable, Subscriber } from 'rxjs';

let nextCallback =  // (5)
      function subscriberNextFunction(x) {
        console.log(x);
      };

let errorCallback =  // (6)
      function subscriberErrorFunction(x) {
          console.log('ERROR ERROR ERROR');
      }

let completeCallback =  // (7)
      function subscriberCompleteFunction() {
          console.log('COMPLETED');
      }

let subscriber = new Subscriber(nextCallback, errorCallback, completeCallback); // (4)

let subscribeFunction =  // (2)
    function subscribe(subscriber: Subscriber<any>) { // (3)
        const id = setInterval(() => {
          subscriber.next('hello');
          subscriber.next('goodbye');
        //   subscriber.error(new Error('help'));
        //   subscriber.complete();
        }, 1000);
      };

const observable = new Observable(subscribeFunction)  // (1)

observable.subscribe(subscriber); // (8)




// (1)
//  A new instance of Observable is created.
//  The constructer takes a function known as "subscribe". This defines the behavior when the Observable is initially "subscribed to"

// (2)
//  The "subscribe" function can be decalred inline like () => {doSomething();}, for clarity I definied it as a variable here

// (3)
//  The "subscribe" function must take a Subscriber as a parameter.
//  Again, this function defines the behavior being observed.  It defines how and when data will be pushed.
//  A Subscriber object may have several callback functions for different types of data being pushed by the observablee

// (4)
//  What is a Subscriber?
//  https://rxjs-dev.firebaseapp.com/api/index/class/Subscriber
//  Subscriber holds the observers and/or callback functions -- It knows what to do when data is pushed out by the Observable.
//  The class describes and asks for up to behavior definitions for 3 outputs of the Observable
//  Next: what happens when the observable pushes the next piece of data
//  Error: what happens when the observable pushes out an error
//  Complete: what happens when the observable is done with it's business
//  Here I'm explicitly creating the Subscriber object, but often this is done more implicitly by passing a function to .subscribe
//  When this is done, it is understood that the function is the NextObserver, observing what happens when the next piece of data is pushed out
//  This less explicit usage is how we most commonly see things in angular, but I wanted to show what was really happening by being more
//  explicit

// (5) 
//  The "next" call back. 
//  Takes in the data being pushed by the observable and deals with it when pushed

// (6)
//  The "error" call back
//  Takes in an error being pushed by the observable and deals with it when pushed

// (7)
//  The "complete" call back
//  Defines what should happen when the observable has completed its work

// (8) 
//  The "subscribe" function is invoked when we call observable.subscribe(subscriber). 
//  At this time the "work" gets done.  The subscribe function is executed. 
//  If the observable only pushes out one synchronous value then all of this has been an overcomplicated function call
//  If the observable pushes out multiple data points, has an asynchronous component then the true power of observables is unlocked
