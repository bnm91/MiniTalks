using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Learning.StrategyPattern.Interfaces
{
    public class RedheadDuck : Duck, IQuackable, IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("[RedheadDuck]");
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
        }

        public void Fly()
        {
            Console.WriteLine("I am flying with my wings");
        }
    }
}
