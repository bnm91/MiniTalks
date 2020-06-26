using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            QuackBehavior = new QuackNatural();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("[RedheadDuck]");
        }
    }
}
