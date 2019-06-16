import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { TimeLine } from 'app/Items/Models/array-models/timeline';
import { LanguageService } from 'app/Items/Services/language-service/language.service';
import * as timelineArray from 'app/Items/Models/arrays/timeline-array';

@Component({
  selector: 'app-timeline',
  templateUrl: './timeline.component.html',
  styleUrls: ['./timeline.component.scss']
})
export class TimelineComponent implements OnInit {

  @Input() timeline: TimeLine[];
  public langSwitch: string;
  constructor(private language: LanguageService) { }

  ngOnInit(): void {
    timelineArray.timeline[0].pulse = '';
    this.language.lang.subscribe(language => this.langSwitch = language);
  }

  ShowDetails(anchor) {
    this.language.SetCompanyName(anchor);
  }

  CheckType(anchor: string, compare: string, active: string, i: number): void {
    if (anchor === compare) {
      timelineArray.timeline[i].pulse = '';
    } else {
      timelineArray.timeline[i].pulse = active;
    }
  }

  RemovePulse(anchor: string) {
    this.CheckType(anchor, 'soft', 'first', 0);
    this.CheckType(anchor, 'szlips', 'second', 1);
    this.CheckType(anchor, 'maur', 'third', 2);
    this.CheckType(anchor, 'polsl', 'fourth', 3);
  }

}
