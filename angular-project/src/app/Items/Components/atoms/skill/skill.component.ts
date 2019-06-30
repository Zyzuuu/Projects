import { Component, OnInit, Input } from '@angular/core';
import { SkillsArray } from 'app/Items/Models/array-models/skills';

@Component({
  selector: 'app-skill',
  templateUrl: './skill.component.html',
  styleUrls: ['./skill.component.scss']
})
export class SkillComponent implements OnInit {

  @Input() skillArray: SkillsArray;
  @Input() desktop: boolean;
  constructor() { }

  ngOnInit() {
  }

}
