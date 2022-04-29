using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.Traditional
{
    public abstract class MenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Print();
    }
}
