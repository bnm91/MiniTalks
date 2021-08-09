using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Template.TemplateMethodWithHook
{
    public class TemplateWithHookCoffeeShop
    {
        public TemplateWithHookCoffeeShop() { }

        public void StandardOrder()
        {
            var coffee = new CoffeeWithHook();
            coffee.PrepareRecipe();
            Console.WriteLine();
            var tea = new TeaWithHook();
            tea.PrepareRecipe();
        }
    }
}
