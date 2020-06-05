using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.WhatNotToDo
{
    public class Jared : IPodcastListener
    {
        public string Name { get; }

        public Jared()
        {
            this.Name = "Jared";
        }

        public string ExcitedlyReviewEpisode(string episodeName)
        {
            return $"I loved the episode {episodeName}. In this 20 part essay I will explain why its the pinnacle of podcasting.....";
        }
    }
}
