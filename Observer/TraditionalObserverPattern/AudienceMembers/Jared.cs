using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.TraditionalObserverPattern
{
    public class Jared : IObserver
    {
        public string Name { get; }

        public Jared()
        {
            this.Name = "Jared";
        }

        public void Update(string newEpisodeName)
        {
            Console.WriteLine(ExcitedlyReviewEpisode(newEpisodeName));
        }

        public string ExcitedlyReviewEpisode(string episodeName)
        {
            return $"{Name}: I loved the episode {episodeName}. In this 20 part essay I will explain why its the pinnacle of podcasting.....";
        }
    }
}
