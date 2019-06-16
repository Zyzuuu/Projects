import { Component, OnInit, Input, HostListener } from '@angular/core';
import { NavLink } from 'app/Items/Models/array-models/nav-link';
import { LanguageService } from 'app/Items/Services/language-service/language.service';
import { JumpToService } from 'app/Items/Services/jump-to/jump-to.service';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';

@Component({
  selector: 'app-nav-link',
  templateUrl: './nav-link.component.html',
  styleUrls: ['./nav-link.component.scss']
})
export class NavLinkComponent implements OnInit {
  navbarItemDisplay = true;
  private active = 'home';
  public langText = 'pl';
  mobile = true;
  @Input() navbarType: boolean;
  @Input() navigateTo: NavLink;

  constructor(private language: LanguageService,
    private jump: JumpToService,
    private scroll: ScrollService) { }

  ngOnInit(): void {
    this.scroll.activeLink.subscribe(activeLink => this.active = activeLink);
    this.language.lang.subscribe(lang => this.langText = lang);
  }
  SetActive = (buttonName: string) => {
    this.active = buttonName;
  }

  IsActive = (buttonName: string) => {
    return this.active === buttonName;
  }

  Scroll(anchor: string) {
    this.jump.scroll(anchor);
  }

  @HostListener('window:scroll', ['$event']) checkWindowPosition(): void {
    this.scroll.ScrollDetect();
  }

}

