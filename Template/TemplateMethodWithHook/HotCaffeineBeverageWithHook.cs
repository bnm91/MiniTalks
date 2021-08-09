using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Template.TemplateMethodWithHook
{
    public abstract class HotCaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();
        public abstract void AddCondiments();
        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

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
