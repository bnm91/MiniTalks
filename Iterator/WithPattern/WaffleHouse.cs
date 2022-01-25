using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator.WithPattern
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

        // Replace GetMenuItems with CreateIterator so that caller can deal with an Iterator instead 
        //public WaffleHouseMenuCollection GetMenuItems()
        //{
        //    return _menuItems;
        //}

        public IIterator CreateIterator()
        {
            return new WaffleHouseMenuIterator(_menuItems);
        }
    }

    public class WaffleHouseMenuCollection
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
    }
}
