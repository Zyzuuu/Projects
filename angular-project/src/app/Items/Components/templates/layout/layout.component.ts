import { Component, OnInit } from '@angular/core';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.scss']
})
export class LayoutComponent implements OnInit {
  public transparency = false;
  constructor(private navbar: ScrollService) { }

  ngOnInit(): void {
    this.navbar.navbarTransparency.subscribe(transparency => this.transparency = transparency);
  }

}
