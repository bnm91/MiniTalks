using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.TraditionalObserverPattern
{
    public class Brad: IObserver
    {
        public string Name { get; }

        public Brad()
        {
            this.Name = "Brad";
        }

        public void Update(string newEpisodeName)
        {
            Console.WriteLine(SayNewHere());
        }

        public string SayNewHere()
        {
            return $"{Name}: Hi, I'm new here";
        }
    }
}
