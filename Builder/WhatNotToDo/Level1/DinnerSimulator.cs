using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Builder.WhatNotToDo.Level1
{
    public class DinnerSimulator : AbstractDinnerSimulator
    {
        public DinnerSimulator() { }

        public override void Run()
        {
            var standardBurger = new Burger();
            standardBurger.Bun = "Sesame Seed";
            standardBurger.Cheese = "Cheddar";
            standardBurger.Protein = "Beef Patty";
            standardBurger.Vegetables = new List<string>() { "Lettuce", "Onion", "Tomato" };
            standardBurger.Condiments = new List<string>() { "Special Sauce" };

            var vegetarianBurger = new Burger();
            vegetarianBurger.Bun = "Seasame Seed";
            vegetarianBurger.Cheese = "Cheddar";
            vegetarianBurger.Protein = "Impossible Patty";
            vegetarianBurger.Vegetables = new List<string>() { "Lettuce", "Onion", "Tomato" };
            vegetarianBurger.Condiments = new List<string>() { "Special Sauce" };

            var glutenFreeBurger = new Burger();
            glutenFreeBurger.Cheese = "Cheddar";
            glutenFreeBurger.Protein = "Beef Patty";
            vegetarianBurger.Vegetables = new List<string>() { "Lettuce", "Onion", "Tomato" };
            vegetarianBurger.Condiments = new List<string>() { "Special Sauce" };

            var veganBurger = new Burger();
            veganBurger.Bun = "Sesame Seed";
            veganBurger.Protein = "Impossible Patty";
            vegetarianBurger.Vegetables = new List<string>() { "Lettuce", "Onion", "Tomato" };

            var burgerNixonsWay = new Burger();
            burgerNixonsWay.Bun = "Sesame Seed";
            burgerNixonsWay.Cheese = "Cheddar";
            burgerNixonsWay.Protein = "Beef Patty";

            var burgers = new List<IBurger>()
            {
                standardBurger,
                vegetarianBurger,
                glutenFreeBurger,
                veganBurger,
                burgerNixonsWay
            };

            base.PrintOrder(burgers);
        }
    }
}
