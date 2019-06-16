import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { TimeLine } from 'app/Items/Models/array-models/timeline';
import * as timelineArray from 'app/Items/Models/arrays/timeline-array';
@Component({
  selector: 'app-timeline-organism',
  templateUrl: './timeline-organism.component.html',
  styleUrls: ['./timeline-organism.component.scss']
})
export class TimelineOrganismComponent implements OnInit {

  public timeline: TimeLine[];
  @Output() displayDetails = new EventEmitter;
  constructor() {
    this.timeline = timelineArray.timeline;
  }

  ngOnInit(): void {
  }

  DisplayContent(anchor) {
    this.displayDetails.emit(anchor);
  }
}
