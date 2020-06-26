using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new QuackMuted();
            FlyBehavior = new FlyNone();
        }

        public override void Display()
        {
            Console.WriteLine("[DecoyDuck]");
        }
    }
}
