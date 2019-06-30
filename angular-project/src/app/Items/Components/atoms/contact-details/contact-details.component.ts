import { Component, OnInit, Input } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-contact-details',
  templateUrl: './contact-details.component.html',
  styleUrls: ['./contact-details.component.scss']
})
export class ContactDetailsComponent implements OnInit {

  @Input() src: string;
  @Input() text: string;
  @Input() background: string;
  @Input() backgroundOne: string;
  @Input() cursor: string;
  @Input() link: any;
  @Input() linked: boolean;
  constructor(private sanitizer: DomSanitizer) { }

  ngOnInit() {
    this.link = this.sanitizer.bypassSecurityTrustUrl(this.link);
  }

}
