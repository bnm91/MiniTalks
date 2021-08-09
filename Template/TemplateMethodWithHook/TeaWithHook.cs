using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Template.TemplateMethodWithHook
{
    public class TeaWithHook : HotCaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
