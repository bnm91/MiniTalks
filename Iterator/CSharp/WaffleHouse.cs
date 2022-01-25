using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator.Csharp
{
    public class WaffleHouse
    {
        private WaffleHouseMenuCollection _menuItems;

        public WaffleHouse()
        {
            _menuItems = new WaffleHouseMenuCollection(3);

            _menuItems.Add(new MenuItem("All Star Breakfast", "Waffle, Scrambled Eggs, Hashbrowns, Bacon", 6.99, false));
            _menuItems.Add(new MenuItem("Smothered and Covered Hashbrowns", "Hashbrowns with cheese, onions, and delicious grease", 1.99, true));
            _menuItems.Add(new MenuItem("Reese's Pieces Waffle", "A waffle with Reese's Pieces in it -- not dessert", 1.99, true));
        }
          
        public WaffleHouseMenuCollection GetMenuItems()
        {
            return _menuItems;
        }
    }

    public class WaffleHouseMenuCollection : IEnumerable<MenuItem>
    {
        public MenuItem[] items;
        private int currentSize = 0;

        public WaffleHouseMenuCollection(int maxSize)
        {
            items = new MenuItem[maxSize];
        }

        public void Add(MenuItem item)
        {
            items[currentSize] = item;
            currentSize++;
        }

        public MenuItem Get(int index)
        {
            return items[index];
        }

        public int Count()
        {
            return currentSize;
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            for(int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators
        // In addition to the generic GetEnumerator method, the non-generic GetEnumerator method must also be implemented. 
        // This is because IEnumerable<T> inherits from IEnumerable. The non-generic implementation defers to the generic implementation.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
