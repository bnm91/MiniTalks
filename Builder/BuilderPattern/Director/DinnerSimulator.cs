using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Builder.BuilderPattern.Director
{
    public class DinnerSimulator: AbstractDinnerSimulator
    {
        public DinnerSimulator() { }

        public override void Run()
        {
            BurgerDirector burgerDirector = new BurgerDirector();

            var standardBurger = burgerDirector.MakeStandardBurger();
            var vegetarianBurger = burgerDirector.MakeVegetarianBurger();
            var glutenFreeBurger = burgerDirector.MakeGlutenFreeBurger();
            var veganBurger = burgerDirector.MakeVeganBurger();
            var burgerNixonsWay = burgerDirector.MakeNixonsWayBurger();


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
