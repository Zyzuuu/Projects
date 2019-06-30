import { Component, OnInit, ViewChild, ElementRef, Renderer2 } from '@angular/core';
import { JumpToService } from 'app/Items/Services/jump-to/jump-to.service';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';
import { CloudService } from 'app/Items/Services/cloud-opacity-change/cloud.service';

@Component({
  selector: 'app-welcome-section',
  templateUrl: './welcome-section.component.html',
  styleUrls: ['./welcome-section.component.scss']
})
export class WelcomeSectionComponent implements OnInit {

  @ViewChild('home') el: ElementRef;
  @ViewChild('cloud') cloudEl: ElementRef;

  constructor(private jump: JumpToService,
    private scroll: ScrollService,
    private render: Renderer2,
    private cloudStatus: CloudService) { }

  ngOnInit(): void {
    this.scroll.SetHomeHeight(this.el.nativeElement.offsetHeight);
    const cloud = this.cloudEl.nativeElement;
    this.cloudStatus.cloud.subscribe(status => {
      if (status === true) {
        this.render.removeClass(cloud, 'transparency');
        this.render.addClass(cloud, 'not-transparency');
      } else if (status === false) {
        this.render.removeClass(cloud, 'not-transparency');
        this.render.addClass(cloud, 'transparency');

      }
    });
  }

  Scroll(anchor: string) {
    this.jump.scroll(anchor, 70);
  }

}
