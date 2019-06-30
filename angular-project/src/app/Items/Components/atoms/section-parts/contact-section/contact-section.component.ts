import { Component, OnInit, ViewChild, ElementRef, HostListener } from '@angular/core';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';
import { SpecificDialogBox } from 'app/Items/Functions/open-dialog-box';
import { MoreMatdialogComponent } from 'app/Items/Components/organisms/more-matdialog/more-matdialog.component';
import { trigger, state, style, transition, animate } from '@angular/animations';

@Component({
  selector: 'app-contact-section',
  templateUrl: './contact-section.component.html',
  styleUrls: ['./contact-section.component.scss'],
  animations: [
    trigger('transition', [
      state('initial', style({ opacity: 0 })),
      state('final', style({ opacity: 1 })),
      transition('initial=>final', animate('1000ms', style({
        opacity: 1,
      }))),
    ]),
  ]
})
export class ContactSectionComponent implements OnInit {

  @ViewChild('contact') el: ElementRef;
  currentState = 'initial';

  constructor(private scroll: ScrollService, private dialog: SpecificDialogBox) { }



  ngOnInit(): void {
    this.scroll.SetContactHeight(this.el.nativeElement.offsetHeight);
  }

  OpenMoreWindow() {
    this.dialog.OpenSpecificDialogBox(MoreMatdialogComponent, '500px', '450px');
  }

  @HostListener('window:scroll', ['$event']) WindowBottomPosition(e): void {

    if ((window.innerHeight + window.scrollY) >= document.body.scrollHeight - 30) {
      this.currentState = 'final';
    }
  }
}
