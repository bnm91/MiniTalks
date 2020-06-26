using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with my wings");
        }
    }
}
