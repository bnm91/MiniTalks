import { Component, OnInit } from '@angular/core';
import { PodcastSource } from '../business/podcast-source';

@Component({
  selector: 'app-matt-component',
  templateUrl: './matt-component.component.html',
  styleUrls: ['./matt-component.component.scss']
})
export class MattComponentComponent implements OnInit {
  lastEpisodeListened: number;
  subscription: any;
  isSubbed = false;

  constructor(private podcastSource: PodcastSource) { }

  ngOnInit() {
  }

  subscribeToPodcast() {
    this.isSubbed = true;
    this.subscription = this.podcastSource.subject.subscribe(x => this.lastEpisodeListened = x);
  }


  unsubscribeFromPodcast() {
    this.isSubbed = false;
    this.subscription.unsubscribe();
  }

}
