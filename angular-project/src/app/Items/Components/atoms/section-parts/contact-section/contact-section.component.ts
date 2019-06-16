import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';

@Component({
  selector: 'app-contact-section',
  templateUrl: './contact-section.component.html',
  styleUrls: ['./contact-section.component.scss']
})
export class ContactSectionComponent implements OnInit {

  @ViewChild('contact') el: ElementRef;

  constructor(private scroll: ScrollService) { }

  ngOnInit(): void {
    this.scroll.SetContactHeight(this.el.nativeElement.offsetHeight);
  }
}


