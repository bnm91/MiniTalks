using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.Interfaces
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("[DecoyDuck]");
        }
    }
}
