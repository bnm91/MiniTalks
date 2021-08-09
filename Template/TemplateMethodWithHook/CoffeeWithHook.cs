using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Template.TemplateMethodWithHook
{
    public class CoffeeWithHook : HotCaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Do you want sugar and milk?");
            String answer = Console.ReadLine();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
