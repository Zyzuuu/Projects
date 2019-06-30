import { Component, OnInit, Input } from '@angular/core';
import { Projects } from 'app/Items/Models/array-models/projects';
import { trigger, style, state, transition, animate } from '@angular/animations';


@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.scss'],
  animations: [
    trigger('showDetails', [
      state('initial', style({
        background: '#333',
        width: '500px',
        height: '100%',
        top: '0px',
        opacity: 0,
      })),
      state('final', style({
        background: '#333',
        width: '500px',
        height: '100%',
        top: '0px',
        opacity: 1,
      })),
      transition('initial=>final', animate('2000ms')),
      transition('final=>initial', animate('2000ms'))
    ]),
  ]
}

) export class ProjectComponent implements OnInit {
  @Input() projects: Projects[];
  public dis = false;
  public app = false;
  public currentState = 'initial';
  constructor() { }

  ngOnInit() {
  }

  ReadMore() {
    this.dis = true;
    this.app = false;
    this.currentState = 'final';
  }

  Close() {
    this.dis = false;
    this.currentState = 'initial';
    this.app = true;
  }
}
