import { Component } from '@angular/core';
import { Subject } from 'rxjs';
import { PodcastSource } from './business/podcast-source';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'subject-demo-app';

  constructor(private podcastSource: PodcastSource) {  }

  publishEpisode() {
    this.podcastSource.publishNewEpisode();
  }
}
