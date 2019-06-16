import { Component, OnInit } from '@angular/core';
import { NavLink } from 'app/Items/Models/array-models/nav-link';
import { ToggleService } from 'app/Items/Services/toggle/toggle.service';
import * as navLinkArray from 'app/Items/Models/arrays/navbar-links-array';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss'],
})


export class NavbarComponent implements OnInit {

  public slide = true;
  public navLinks: NavLink[];
  public currentState = 'initial';
  public transparency = false;

  constructor(private toggle: ToggleService,
    private navbar: ScrollService) {
    this.navLinks = navLinkArray.navLinks;
  }

  ngOnInit(): void {
    this.navbar.navbarTransparency.subscribe(transparency => this.transparency = transparency);
  }

  Toggle() {
    this.toggle.SetToggleStatus(this.currentState = this.currentState === 'initial' ? 'final' : 'initial');
  }
}
