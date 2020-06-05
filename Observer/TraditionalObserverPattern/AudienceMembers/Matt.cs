using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.TraditionalObserverPattern
{
    public class Matt : IObserver
    {
        public string Name { get; }

        public Matt()
        {
            this.Name = "Matt";
        }

        public void Update(string newEpisodeName)
        {
            Console.WriteLine(IgnoreCompletely());
        }

        public string IgnoreCompletely()
        {
            return $"{Name}:";
        }
    }
}
