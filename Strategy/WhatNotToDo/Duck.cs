using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Learning.StrategyPattern.WhatNotToDo
{
    public class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Quack!");
        }
        
        public virtual void Swim()
        {
            Console.WriteLine("I am swimming");
        }

        public virtual void Fly()
        {
            Console.WriteLine("I am flying with my wings");
        }

        public virtual void Display()
        {
            Console.WriteLine("[Duck]");
        }
    }
}
