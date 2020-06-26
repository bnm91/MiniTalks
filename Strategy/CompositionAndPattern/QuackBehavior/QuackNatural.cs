using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public class QuackNatural : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
