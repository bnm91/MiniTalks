using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.Traditional
{
    // This is the Client
    public class SuperRestaurantServer
    {
        private readonly MenuComponent _allMenus;

        public SuperRestaurantServer(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}
