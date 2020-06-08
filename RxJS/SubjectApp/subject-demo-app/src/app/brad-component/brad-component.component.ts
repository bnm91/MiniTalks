import { Component, OnInit } from '@angular/core';
import { PodcastSource } from '../business/podcast-source';

@Component({
  selector: 'app-brad-component',
  templateUrl: './brad-component.component.html',
  styleUrls: ['./brad-component.component.scss']
})
export class BradComponentComponent implements OnInit {
  lastEpisodeListened: number;

  constructor(private podcastSource: PodcastSource) { }

  ngOnInit() {
  }

  subscribeToPodcast() {
    this.podcastSource.subject.subscribe(x => this.lastEpisodeListened = x);
  }

  unsubscribeFromPodcast() {
    this.podcastSource.subject.unsubscribe();
  }

}
