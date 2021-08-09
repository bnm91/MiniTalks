using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Template.TemplateMethod
{
    public abstract class HotCaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
