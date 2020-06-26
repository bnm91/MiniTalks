using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.WhatNotToDo
{
    public static class StrategyPatternWhatNotToDoExample2
    {
        public static void Do()
        {
            var duckData = new DuckData();
            duckData.Write(new RubberDuck());

            var ducks = duckData.ReadAll();

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Fly();
                duck.Quack();
                Console.WriteLine();
            }
        }
    }
}
