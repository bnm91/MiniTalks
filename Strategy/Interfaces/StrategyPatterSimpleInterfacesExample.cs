using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.Interfaces
{
    public static class StrategyPatternSimpleInterfacesExample
    {
        public static void Do()
        {
            var duckData = new DuckData();
            duckData.Write(new RubberDuck());
            duckData.Write(new DecoyDuck());

            var ducks = duckData.ReadAll();

            foreach (var duck in ducks)
            {
                duck.Display();
                //duck.Fly(); // COMPILE ERROR!!
                if (duck is IFlyable flyableDuck)
                {
                    flyableDuck.Fly();
                }

                if (duck is IQuackable quackableDuck)
                {
                    quackableDuck.Quack();
                }
                Console.WriteLine();
            }
        }
    }
}
