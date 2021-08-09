using System;

namespace Learning.Template.TemplateMethod
{
    public class Coffee : HotCaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
