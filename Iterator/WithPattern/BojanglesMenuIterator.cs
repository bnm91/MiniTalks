using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator.WithPattern
{
    public class BojanglesMenuIterator : IIterator
    {
        private MenuItem[] Items;
        private int Position = 0;

        public BojanglesMenuIterator(MenuItem[] items)
        {
            Items = items;
        }

        public bool HasNext()
        {
            if (Position >= Items.Length || Items[Position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            MenuItem item = Items[Position];
            Position += 1;
            return item;
        }
    }
}
