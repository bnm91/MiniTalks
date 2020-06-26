using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public Duck() { }

        public Duck(IFlyBehavior fly, IQuackBehavior quack)
        {
            FlyBehavior = fly;
            QuackBehavior = quack;
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public virtual void Display()
        {
            Console.WriteLine("[Duck]");
        }
    }
}
