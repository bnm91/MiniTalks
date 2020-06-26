using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.WhatNotToDo
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("[MallardDuck]");
        }
    }
}
