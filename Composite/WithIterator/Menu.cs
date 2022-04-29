using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.WithIterator
{
    public class Menu : MenuComponent
    {
        private IEnumerator enumerator = null;
        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override IEnumerator CreateEnumerator()
        {
            if(enumerator == null)
            {
                enumerator = new MenuComponentEnumerator(_menuComponents.GetEnumerator());
            }
            return enumerator; 
        }

        public override void Print()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine(Name);
            Console.WriteLine("* " + Description);
            Console.WriteLine("---------------------");

            foreach (var component in _menuComponents)  // Remember the iterator pattern? :) 
            {
                component.Print();
            }

            Console.WriteLine();
        }

        public MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }
    }
}
