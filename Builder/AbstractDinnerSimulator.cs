using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Builder
{

    // Abstract class for simulators used to demonstrate Builder pattern
    public abstract class AbstractDinnerSimulator
    {
        public abstract void Run();


        // Print out the order as if being read back by a cashier
        public void PrintOrder(List<IBurger> burgers)
        {
            foreach(var burger in burgers)
            {
                Console.WriteLine("One " + burger.ToString());
            }
        }
    }
}
