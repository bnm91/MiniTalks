using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
