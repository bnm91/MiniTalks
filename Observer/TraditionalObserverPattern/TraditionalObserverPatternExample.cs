using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning.Observer.TraditionalObserverPattern
{
    public static class TraditionalObserverPatternExample
    {
        // C#, like many languages, as libraries to support this pattern. 
        // For example there is an IObservable<T> and IObserver<T> generic already
        // I have intentionally ignored those to show how this pattern can be implemented
        // without any third party magic



        public static void Do()
        {
           BallerBallPodcast podcast = new BallerBallPodcast();


            // Everybody RING. THAT. BELL.
            podcast.RegisterObserver(new Trestin());
            podcast.RegisterObserver(new Matt());
            podcast.RegisterObserver(new Jared());
            podcast.RegisterObserver(new Katy());

            // first episode!
            Console.WriteLine();
            Console.WriteLine("Episode 1 Published");
            podcast.PublishNewEpisode("Episode 1");

            // Matt leaves us
            podcast.RemoveObserver(podcast.Subscribers.Where(x => 
                x.GetType() == typeof(Matt)).FirstOrDefault()
            );

            // Second Episode
            Console.WriteLine();
            Console.WriteLine("Episode 2 Published");
            podcast.PublishNewEpisode("Episode 2");

            // Brad LIKES AND SUBSCRIBES
            podcast.RegisterObserver(new Brad());

            // Third Episode
            Console.WriteLine();
            Console.WriteLine("Episode 3 Published");
            podcast.PublishNewEpisode("Episode 3");

        }
    }
}
