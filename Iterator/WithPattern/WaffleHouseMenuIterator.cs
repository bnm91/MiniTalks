using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator.WithPattern
{
    public class WaffleHouseMenuIterator : IIterator
    {
        private WaffleHouseMenuCollection Items;
        private int Position = 0;

        public WaffleHouseMenuIterator(WaffleHouseMenuCollection items)
        {
            Items = items;
        }

        public bool HasNext()
        {
            if (Position >= Items.Count() || Items.Get(Position) == null)
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
            MenuItem item = Items.Get(Position);
            Position += 1;
            return item;
        }
    }
}
