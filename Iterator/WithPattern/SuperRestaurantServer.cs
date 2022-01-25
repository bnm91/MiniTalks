using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator.WithPattern
{
    public class SuperRestaurantServer
    {
        Bojangles Bojangles;
        WaffleHouse WaffleHouse;

        public SuperRestaurantServer() 
        {
            Bojangles = new Bojangles();
            WaffleHouse = new WaffleHouse();
        }

        public void PrintMenu()
        {
            IIterator waffleHouseMenuIterator = WaffleHouse.CreateIterator();
            IIterator bojanglesMenuIterator = Bojangles.CreateIterator();

            PrintMenu(waffleHouseMenuIterator);
            PrintMenu(bojanglesMenuIterator);
        }

        private void PrintMenu(IIterator iterator)
        {
            while(iterator.HasNext())
            {
                MenuItem item = (MenuItem)iterator.Next();
                Console.WriteLine($"{item.Name} for ${item.Price}");
            }
        }
    }
}
