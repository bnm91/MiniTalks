using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.TraditionalObserverPattern
{
    public class Trestin : IObserver
    {
        public string Name { get;  }

        public Trestin()
        {
            this.Name = "Trestin";
        }

        public void Update(string newEpisodeName)
        {
            Console.WriteLine(PretendToHaveListened(newEpisodeName));
        }

        private string PretendToHaveListened(string episodeName)
        {
            return $"{Name}: {episodeName}? Oh yeah I think I listened to part of it";
        }
    }
}
