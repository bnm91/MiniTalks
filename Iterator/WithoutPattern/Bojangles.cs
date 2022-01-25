using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator.WithoutPattern
{
    public class Bojangles
    {
        private MenuItem[] _menuItems;

        public Bojangles()
        {
            _menuItems = new MenuItem[4];
            _menuItems[0] = new MenuItem("Sweet Tea", "Sugar with tea flavoring", 0.99, true);
            _menuItems[1] = new MenuItem("Butter Biscuit", "Biscuit sliced and buttered", 0.99, true);
            _menuItems[2] = new MenuItem("Bacon, Egg, and Cheese Biscuit", "2 strips of bacon, american cheese, and an egg inside a biscuit", 2.99, false);
            _menuItems[3] = new MenuItem("4 pc Supremes Meal", "4 Chicken Supremes, Cajun fries, and a biscuit w/ tea", 5.99, false);
        }

        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }
    }
}
