import { Component, OnInit, Input } from '@angular/core';
import { SkillsArray } from 'app/Items/Models/array-models/skills';
import * as skill from 'app/Items/Models/arrays/skills-array';
@Component({
  selector: 'app-skills',
  templateUrl: './skills.component.html',
  styleUrls: ['./skills.component.scss']
})
export class SkillsComponent implements OnInit {

  skillArray: SkillsArray[];
  @Input() desktop: boolean;
  constructor() { this.skillArray = skill.skills; }

  ngOnInit() {
  }
}
