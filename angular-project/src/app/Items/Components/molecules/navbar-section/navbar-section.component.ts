import { Component, OnInit, Input } from '@angular/core';
import { NavLink } from 'app/Items/Models/array-models/nav-link';

@Component({
  selector: 'app-navbar-section',
  templateUrl: './navbar-section.component.html',
  styleUrls: ['./navbar-section.component.scss']
})
export class NavbarSectionComponent implements OnInit {

  @Input() navlinkOptions: Array<NavLink>;

  constructor() { }

  ngOnInit(): void {
  }
}
