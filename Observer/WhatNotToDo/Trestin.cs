using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.WhatNotToDo
{
    public class Trestin : IPodcastListener
    {
        public string Name { get;  }

        public Trestin()
        {
            this.Name = "Trestin";
        }

        public string PretendToHaveListened(string episodeName)
        {
            return $"{episodeName}? Oh yeah I think I listened to part of it";
        }
    }
}
