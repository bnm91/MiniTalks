using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Template.WithoutPattern
{
    public class WithoutPatternCoffeeShop
    {
        public WithoutPatternCoffeeShop() { }

        public void StandardOrder()
        {
            var coffee = new Coffee();
            var tea = new Tea();
            coffee.PrepareRecipe();
            Console.WriteLine();
            tea.PrepareRecipe();
        }
    }
}
