using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Builder.BuilderPattern
{
    public class DinnerSimulator : AbstractDinnerSimulator
    {
        public DinnerSimulator() { }

        public override void Run()
        {
            BurgerBuilder burgerBuilder = new BurgerBuilder();


            var standardBurger = burgerBuilder
                .WithProtein("Beef Patty")
                .OnBun("Sesame Seed")
                .CoveredWithCheese("Cheddar")
                .WithCondiment("Special Sauce")
                .WithVegetable("Lettuce").WithVegetable("Onion").WithVegetable("Tomato")
                .BuildBurger();

            burgerBuilder.Reset();
            var vegetarianBurger = burgerBuilder
                .WithProtein("Impossible Patty")
                .OnBun("Sesame Seed")
                .CoveredWithCheese("Cheddar")
                .WithCondiment("Special Sauce")
                .WithVegetable("Lettuce").WithVegetable("Onion").WithVegetable("Tomato").WithVegetable("Pickles")
                .BuildBurger();

            burgerBuilder.Reset();
            var glutenFreeBurger = burgerBuilder
                .WithProtein("Beef Patty")
                .CoveredWithCheese("Cheddar")
                .WithCondiment("Special Sauce")
                .WithVegetable("Lettuce").WithVegetable("Onion").WithVegetable("Tomato")
                .BuildBurger();

            burgerBuilder.Reset();
            var veganBurger = burgerBuilder
                .WithProtein("Impossible Patty")
                .OnBun("Sesame Seed")
                .WithVegetable("Lettuce").WithVegetable("Onion").WithVegetable("Tomato").WithVegetable("Pickles")
                .BuildBurger();

            burgerBuilder.Reset();
            var burgerNixonsWay = burgerBuilder
                .WithProtein("Beef Patty")
                .OnBun("Sesame Seed")
                .CoveredWithCheese("Cheddar")
                .BuildBurger();


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
