using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Template.WithoutPattern
{
    public class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
