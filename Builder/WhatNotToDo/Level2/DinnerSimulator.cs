using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Builder.WhatNotToDo.Level2
{
    public class DinnerSimulator : AbstractDinnerSimulator
    {
        public DinnerSimulator() { }

        public override void Run()
        {
            var standardBurger = new Burger(
                "Sesame Seed",
                "Beef Patty",
                null,
                new List<string>() { "Special Sauce" },
                new List<string>() { "Lettuce", "Onion", "Tomato" },
                "Cheddar",
                null
                );

            var vegetarianBurger = new Burger(
                "Sesame Seed",
                "Impossible Patty",
                null,
                new List<string>() { "Special Sauce" },
                new List<string>() { "Lettuce", "Onion", "Tomato", "Pickles" },
                "Cheddar",
                null
                );

            var glutenFreeBurger = new Burger(
                null,
                "Beef Patty",
                null,
                new List<string>() { "Special Sauce" },
                new List<string>() { "Lettuce", "Onion", "Tomato" },
                "Cheddar",
                null
                );

            var veganBurger = new Burger(
                "Sesame Seed",
                "Impossible Patty",
                null,
                null,
                new List<string>() { "Lettuce", "Onion", "Tomato" },
                null,
                null
                );

            var burgerNixonsWay = new Burger(
                "Sesame Seed",
                "Beef Patty",
                null,
                null,
                null,
                "Cheddar",
                null
                );

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
