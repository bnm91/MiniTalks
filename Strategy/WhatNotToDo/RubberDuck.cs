using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.WhatNotToDo
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("[RubberDuck]");
        }

        public override void Quack()
        {
            Squeak();
        }

        private void Squeak()
        {
            Console.WriteLine("Squeak!");
        }



        //public override void Fly()
        //{

        //}
    }
}
