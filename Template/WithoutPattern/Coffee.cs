﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Template.WithoutPattern
{
    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
