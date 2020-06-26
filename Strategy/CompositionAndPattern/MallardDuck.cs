using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new QuackNatural();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("[MallardDuck]");
        }
    }
}
