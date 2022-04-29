using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.WithIterator
{
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

        public override IEnumerator CreateEnumerator()
        {
            return new NullEnumerator();
        }

        public override void Print()
        {
            Console.WriteLine($"{Name}, {Price}    -- {Description}");
        }
    }
}
