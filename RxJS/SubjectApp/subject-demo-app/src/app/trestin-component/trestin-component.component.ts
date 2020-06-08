import { Component, OnInit } from '@angular/core';
import { PodcastSource } from '../business/podcast-source';

@Component({
  selector: 'app-trestin-component',
  templateUrl: './trestin-component.component.html',
  styleUrls: ['./trestin-component.component.scss']
})
export class TrestinComponentComponent implements OnInit {
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
