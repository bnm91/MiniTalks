using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.Traditional
{
    // This is the leaf
    public class MenuItem : MenuComponent
    {
        public double Price { get; set; }
        public bool IsVegetarian { get; set; }

        public MenuItem(string name, 
            string description, 
            double price, 
            bool isVegetarian = false)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegetarian = isVegetarian;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name}, {Price}    -- {Description}");
        }
    }
}
