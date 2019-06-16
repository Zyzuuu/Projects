import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';

@Component({
  selector: 'app-projects-section',
  templateUrl: './projects-section.component.html',
  styleUrls: ['./projects-section.component.scss']
})
export class ProjectsSectionComponent implements OnInit {
  @ViewChild('projects') el: ElementRef;
  constructor(private scroll: ScrollService) { }

  ngOnInit(): void {
    this.scroll.SetProjectsHeight(this.el.nativeElement.offsetHeight);
  }

}
