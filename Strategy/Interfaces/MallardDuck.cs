using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.Interfaces
{
    public class MallardDuck : Duck, IQuackable, IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("[MallardDuck]");
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
