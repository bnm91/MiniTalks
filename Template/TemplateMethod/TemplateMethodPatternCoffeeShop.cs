using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Template.TemplateMethod
{
    public class TemplateMethodPatternCoffeeShop
    {
        public TemplateMethodPatternCoffeeShop() { }

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
