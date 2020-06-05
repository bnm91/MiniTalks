using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.WhatNotToDo
{
    public class Brad: IPodcastListener
    {
        public string Name { get; }

        public Brad()
        {
            this.Name = "Brad";
        }

        public string SayNewHere()
        {
            return "Hi, I'm new here";
        }
    }
}
