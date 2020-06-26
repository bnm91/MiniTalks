using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public class QuackMuted : IQuackBehavior
    {
        public void Quack()
        {
        }
    }
}
