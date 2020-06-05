using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.TraditionalObserverPattern
{
    public class Katy : IObserver
    {
        public string Name { get; }
        public Katy()
        {
            this.Name = "Katy";
        }

        public void Update(string newEpisodeName)
        {
            Console.WriteLine(AdmitToNotHavingListened(newEpisodeName));
        }

        public string AdmitToNotHavingListened(string episodeName)
        {
            return $"{Name}: I did not listen to {episodeName}";
        }
    }
}
