using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.Interfaces
{
    public class Duck
    {

        public virtual void Swim()
        {
            Console.WriteLine("I am swimming");
        }

        public virtual void Display()
        {
            Console.WriteLine("[Duck]");
        }
    }
}
