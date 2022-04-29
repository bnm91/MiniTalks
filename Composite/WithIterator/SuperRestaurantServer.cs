using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.WithIterator
{
    public class SuperRestaurantServer
    {
        private MenuComponent _allMenus;

        public SuperRestaurantServer(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator enumerator = _allMenus.CreateEnumerator();
            Console.WriteLine("VEGETARIAN MENU");
            Console.WriteLine("--------");

            do
            {
                if (enumerator.Current is MenuItem menuItem)
                {
                    if (menuItem.IsVegetarian)
                    {
                        menuItem.Print();
                    }
                }
            } while (enumerator.MoveNext());
        }
    }
}
