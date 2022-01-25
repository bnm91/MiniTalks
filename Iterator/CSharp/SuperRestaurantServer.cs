using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator.Csharp
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
            PrintMenu(WaffleHouse.GetMenuItems());
            PrintMenu(Bojangles.GetMenuItems());
        }

        // C# Arrays are already IEnumerable!
        private void PrintMenu(IEnumerable<MenuItem> menuItems)
        {
            foreach (var item in menuItems)
            {
                Console.WriteLine($"{item.Name} for ${item.Price}");
            }
        }
    }
}
