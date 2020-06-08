import { Component, OnInit } from '@angular/core';
import { PodcastSource } from '../business/podcast-source';

@Component({
  selector: 'app-jared-component',
  templateUrl: './jared-component.component.html',
  styleUrls: ['./jared-component.component.scss']
})
export class JaredComponentComponent implements OnInit {
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
