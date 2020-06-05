using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.WhatNotToDo
{
    public class Katy : IPodcastListener
    {
        public string Name { get; }
        public Katy()
        {
            this.Name = "Katy";
        }

        public string AdmitToNotHavingListened(string episodeName)
        {
            return $"I did not listen to {episodeName}";
        }
    }
}
