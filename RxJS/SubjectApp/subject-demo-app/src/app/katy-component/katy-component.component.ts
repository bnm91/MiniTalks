import { Component, OnInit } from '@angular/core';
import { PodcastSource } from '../business/podcast-source';

@Component({
  selector: 'app-katy-component',
  templateUrl: './katy-component.component.html',
  styleUrls: ['./katy-component.component.scss']
})
export class KatyComponentComponent implements OnInit {
  lastEpisodeListened: number;
  subscription: any;

  constructor(private podcastSource: PodcastSource) { }

  ngOnInit() {
  }

  subscribeToPodcast() {
    this.subscription = this.podcastSource.subject.subscribe(x => this.lastEpisodeListened = x);
  }


  unsubscribeFromPodcast() {
    this.subscription.unsubscribe();
  }

}
