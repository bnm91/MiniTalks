using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public class FlyWithJetpack : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("BLASTOFF! I am flying with a jet pack");
        }
    }
}
