import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { JumpToService } from 'app/Items/Services/jump-to/jump-to.service';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';

@Component({
  selector: 'app-welcome-section',
  templateUrl: './welcome-section.component.html',
  styleUrls: ['./welcome-section.component.scss']
})
export class WelcomeSectionComponent implements OnInit {
  @ViewChild('home') el: ElementRef;
  constructor(private jump: JumpToService,
    private scroll: ScrollService) { }

  ngOnInit(): void {
    this.scroll.SetHomeHeight(this.el.nativeElement.offsetHeight);
  }

  Scroll(anchor: string) {
    this.jump.scroll(anchor);
  }

}
