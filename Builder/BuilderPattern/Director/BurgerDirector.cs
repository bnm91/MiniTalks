using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Builder.BuilderPattern.Director
{
    public class BurgerDirector : IBurgerDirector
    {
        BurgerBuilder _burgerBuilder;
        public BurgerDirector()
        {
            _burgerBuilder = new BurgerBuilder();
        }

        public Burger MakeStandardBurger()
        {
            _burgerBuilder.Reset();
            return _burgerBuilder
               .WithProtein("Beef Patty")
               .OnBun("Sesame Seed")
               .CoveredWithCheese("Cheddar")
               .WithCondiment("Special Sauce")
               .WithVegetable("Lettuce").WithVegetable("Onion").WithVegetable("Tomato")
               .BuildBurger();
        }

        public Burger MakeVegetarianBurger()
        {
            _burgerBuilder.Reset();
            return _burgerBuilder
                .WithProtein("Impossible Patty")
                .OnBun("Sesame Seed")
                .CoveredWithCheese("Cheddar")
                .WithCondiment("Special Sauce")
                .WithVegetable("Lettuce").WithVegetable("Onion").WithVegetable("Tomato").WithVegetable("Pickles")
                .BuildBurger();
        }

        public Burger MakeGlutenFreeBurger()
        {
            _burgerBuilder.Reset();
            return _burgerBuilder
                .WithProtein("Beef Patty")
                .CoveredWithCheese("Cheddar")
                .WithCondiment("Special Sauce")
                .WithVegetable("Lettuce").WithVegetable("Onion").WithVegetable("Tomato")
                .BuildBurger();
        }

        public Burger MakeVeganBurger()
        {
            _burgerBuilder.Reset();
            return _burgerBuilder
                .WithProtein("Impossible Patty")
                .OnBun("Sesame Seed")
                .WithVegetable("Lettuce").WithVegetable("Onion").WithVegetable("Tomato").WithVegetable("Pickles")
                .BuildBurger();
        }

        public Burger MakeNixonsWayBurger()
        {
            _burgerBuilder.Reset();
            return _burgerBuilder
                .WithProtein("Beef Patty")
                .OnBun("Sesame Seed")
                .CoveredWithCheese("Cheddar")
                .BuildBurger();
        }
    }
}
