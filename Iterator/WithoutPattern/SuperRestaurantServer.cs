using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator.WithoutPattern
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
            WaffleHouseMenuCollection waffleHouseMenu = WaffleHouse.GetMenuItems();
            MenuItem[] bojanglesMenu = Bojangles.GetMenuItems();

            for (int i = 0; i < waffleHouseMenu.Count(); i++)
            {
                Console.WriteLine($"{waffleHouseMenu.Get(i).Name} for ${waffleHouseMenu.Get(i).Price}");
            }

            for (int i = 0; i < bojanglesMenu.Length; i++)
            {
                Console.WriteLine($"{bojanglesMenu[i].Name} for ${bojanglesMenu[i].Price}");
            }
        }
    }
}
