using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.WithIterator
{
    public abstract class MenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract IEnumerator CreateEnumerator();

        public abstract void Print();
    }
}
