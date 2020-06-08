import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';


@Injectable({ providedIn: 'root' })
export class PodcastSource {
    public subject = new Subject<number>();
    private episodeNumber = 0;

    publishNewEpisode() {
        this.episodeNumber++;
        this.subject.next(this.episodeNumber);
    }
}