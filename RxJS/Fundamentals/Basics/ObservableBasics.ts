// npm install rxjs
// follow this: https://code.visualstudio.com/docs/typescript/typescript-compiling
// NOTE: set up tsconfig.json to use es2016 (link above specifies es5 which is too old)


import { Observable } from 'rxjs';

const observable = new Observable(function subscribe(subscriber) {
    const id = setInterval(() => {
      subscriber.next('hello');
      subscriber.next('goodbye');
    }, 1000);
  });

  observable.subscribe(x => console.log(x));