using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Learning.StrategyPattern.WhatNotToDo
{
    public class RedheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("[RedheadDuck]");
        }
    }
}
