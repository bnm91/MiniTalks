import { Component, OnInit } from '@angular/core';
import { PodcastSource } from '../business/podcast-source';
import { isUndefined } from 'util';

@Component({
  selector: 'app-brad-component',
  templateUrl: './brad-component.component.html',
  styleUrls: ['./brad-component.component.scss']
})
export class BradComponentComponent implements OnInit {
  lastEpisodeListened: number;
  subscription: any;
  isSubbed: boolean = false;

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
