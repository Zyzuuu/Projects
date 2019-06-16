import { Component, OnInit } from '@angular/core';
import { trigger, state, style, animate, transition } from '@angular/animations';
import { ToggleService } from 'app/Items/Services/toggle/toggle.service';
import { NavLink } from 'app/Items/Models/array-models/nav-link';
import * as navLinkArray from 'app/Items/Models/arrays/navbar-links-array';
@Component({
  selector: 'app-mobile-navbar',
  templateUrl: './mobile-navbar.component.html',
  styleUrls: ['./mobile-navbar.component.scss'],
  animations: [
    trigger('changeDivSize', [
      state('initial', style({
        background: '#333',
        position: 'fixed',
        width: '130px',
        height: '100vh',
        top: '0px',
        left: '-250px',
      })),
      state('final', style({
        background: '#333',
        position: 'fixed',
        width: '130px',
        height: '100vh',
        top: '0px',
        left: '0px',
      })),
      transition('initial=>final', animate('500ms')),
      transition('final=>initial', animate('500ms'))
    ]),
  ]
})

export class MobileNavbarComponent implements OnInit {

  public currentState: string;
  public navLinks: NavLink[];

  constructor(private toggle: ToggleService) {
    this.navLinks = navLinkArray.navLinks;
  }

  ngOnInit(): void {
    this.toggle.toggleNavbar.subscribe(status => this.currentState = status);
  }
}
