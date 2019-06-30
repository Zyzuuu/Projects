import { Component, OnInit, Input } from '@angular/core';
import { TimeLine } from 'app/Items/Models/array-models/timeline';
import { LanguageService } from 'app/Items/Services/language-service/language.service';
import * as timelineArray from 'app/Items/Models/arrays/timeline-array';
import { ChangeAvatarService } from 'app/Items/Services/avatar-type-change/change-avatar.service';

@Component({
  selector: 'app-timeline',
  templateUrl: './timeline.component.html',
  styleUrls: ['./timeline.component.scss']
})
export class TimelineComponent implements OnInit {

  @Input() timeline: TimeLine[];
  public langSwitch: string;
  constructor(private language: LanguageService, private avatar: ChangeAvatarService) { }

  ngOnInit(): void {
    timelineArray.timeline[0].pulse = '';
    this.language.lang.subscribe(language => this.langSwitch = language);
  }

  ShowDetails(anchor, type) {
    this.language.SetCompanyName(anchor);
    this.avatar.SetAvatarType(type);
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
