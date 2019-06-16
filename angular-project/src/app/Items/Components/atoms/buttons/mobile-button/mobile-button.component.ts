import { Component, OnInit } from '@angular/core';
import { ToggleService } from 'app/Items/Services/toggle/toggle.service';

@Component({
  selector: 'app-mobile-button',
  templateUrl: './mobile-button.component.html',
  styleUrls: ['./mobile-button.component.scss']
})
export class MobileButtonComponent implements OnInit {
  public active = 'notactive';
  public isActive = 'initial';

  constructor(
    private toggle: ToggleService
  ) { }

  ngOnInit(): void {
    this.toggle.toggleNavbar.subscribe(toggle => this.isActive = toggle);
  }

  SetActive = (buttonName: string) => {
    if (this.isActive === 'initial') {
      this.active = buttonName;
      this.isActive = 'final';
    } else {
      this.active = 'notactive';
      this.isActive = 'initial';
    }
  }

  IsActive = (buttonName: string) => {
    return this.active === buttonName;
  }

}
