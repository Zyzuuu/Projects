import { Component, OnInit, Input } from '@angular/core';
import { Projects } from 'app/Items/Models/array-models/projects';
import * as ProjectsArray from 'app/Items/Models/arrays/language-arrays/projects-lang-array';
import { LanguageService } from 'app/Items/Services/language-service/language.service';
@Component({
  selector: 'app-projects',
  templateUrl: './projects.component.html',
  styleUrls: ['./projects.component.scss']
})
export class ProjectsComponent implements OnInit {
  @Input() projects: Projects[];
  constructor(private language: LanguageService) { }

  ngOnInit() {
    this.language.lang.subscribe(language => {
      if (language === 'pl') {
        this.projects = ProjectsArray.projectsPL;
      } else {
        this.projects = ProjectsArray.projectsENG;
      }
    });

  }

}
