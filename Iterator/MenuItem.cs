using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsVegetarian { get; set; }
        
        public MenuItem(string name, string description, double price, bool isVegetarian)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegetarian = isVegetarian;
        }
    }
}
