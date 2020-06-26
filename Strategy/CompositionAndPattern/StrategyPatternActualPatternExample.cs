using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.CompositionAndPattern
{
    public static class StrategyPatternActualPatternExample
    {
        public static void Do()
        {
            var duckData = new DuckData();
            duckData.Write(new RubberDuck());
            duckData.Write(new DecoyDuck());
            MallardDuck experimentationDuck = new MallardDuck();
            duckData.Write(experimentationDuck);

            var ducks = duckData.ReadAll();

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();
                Console.WriteLine();
            }

            duckData.Delete(experimentationDuck);
            duckData.Write(TransformMallardToJetDuck(experimentationDuck));

            ducks = duckData.ReadAll();

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();
                Console.WriteLine();
            }

        }

        private static MallardDuck TransformMallardToJetDuck(MallardDuck mallard)
        {
            mallard.FlyBehavior = new FlyWithJetpack();
            return mallard;
        }
    }
}
