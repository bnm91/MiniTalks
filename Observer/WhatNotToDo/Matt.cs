using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.WhatNotToDo
{
    public class Matt : IPodcastListener
    {
        public string Name { get; }

        public Matt()
        {
            this.Name = "Matt";
        }

        public string IgnoreCompletely()
        {
            return $"";
        }
    }
}
