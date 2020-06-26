using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.Interfaces
{
    public class RubberDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("[RubberDuck]");
        }

        public void Quack()
        {
            Squeak();
        }

        private void Squeak()
        {
            Console.WriteLine("Squeak!");
        }


    }
}
