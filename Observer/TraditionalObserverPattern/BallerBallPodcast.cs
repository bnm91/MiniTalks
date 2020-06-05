using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.TraditionalObserverPattern
{
    public class BallerBallPodcast : IObservable
    {
        public string CurrentEpisode { get; set; }
        public List<IObserver> Subscribers { get; set; }

        public BallerBallPodcast()
        {
            Subscribers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            Subscribers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Subscribers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(IObserver subscriber in Subscribers)
            {
                subscriber.Update(CurrentEpisode);
            }
        }

        public void PublishNewEpisode(string newEpisodeName)
        {
            CurrentEpisode = newEpisodeName;
            NotifyObservers();
        }
    }
}
