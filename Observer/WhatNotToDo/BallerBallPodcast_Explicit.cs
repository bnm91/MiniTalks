using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Observer.WhatNotToDo
{
    public class BallerBallPodcast_Explicit
    {
        public string CurrentEpisode { get; set; }
        public Jared Jared { get; set; }
        public Katy Katy { get; set; }
        public Trestin Trestin { get; set; }
        public Matt Matt { get; set; }
        public Brad Brad { get; set; }

        public BallerBallPodcast_Explicit()
        {
            Jared = new Jared();
            Katy = new Katy();
            Trestin = new Trestin();
            Matt = new Matt();
            Brad = new Brad();
        }

        public void PublishNewEpisode(string episodeName)
        {
            Console.WriteLine(this.Jared.ExcitedlyReviewEpisode(episodeName));
            Console.WriteLine(this.Katy.AdmitToNotHavingListened(episodeName));
            Console.WriteLine(this.Trestin.PretendToHaveListened(episodeName));
            Console.WriteLine(this.Matt.IgnoreCompletely());
        }
    }
}
