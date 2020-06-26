using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.WhatNotToDo
{
    public static class StrategyPatternWhatNotToDoExample
    {
        public static void Do()
        {
            var data = new DuckData().ReadAll();

            foreach (var duck in data)
            {
                duck.Display();
                duck.Fly();
                duck.Quack();
                Console.WriteLine();
            }
        }
    }
}
