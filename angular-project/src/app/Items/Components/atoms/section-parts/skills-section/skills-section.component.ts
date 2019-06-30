import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';

@Component({
  selector: 'app-skills-section',
  templateUrl: './skills-section.component.html',
  styleUrls: ['./skills-section.component.scss']
})
export class SkillsSectionComponent implements OnInit {
  @ViewChild('skills') el: ElementRef;
  @ViewChild('skillss') element: ElementRef;
  constructor(private scroll: ScrollService) { }

  ngOnInit(): void {
    this.scroll.SetSkillsHeight(this.el.nativeElement.offsetHeight);
  }

}
