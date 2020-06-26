using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNone();
        }

        public override void Display()
        {
            Console.WriteLine("[RubberDuck]");
        }
    }
}
