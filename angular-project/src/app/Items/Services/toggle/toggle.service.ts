import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ToggleService {

  private changeNavbarList = new BehaviorSubject(true);
  changeNavbar = this.changeNavbarList.asObservable();

  private toggle = new BehaviorSubject('initial');
  toggleNavbar = this.toggle.asObservable();

  constructor() { }

  SetToggleStatus(toggle: string) {
    this.toggle.next(toggle);
  }

  SetNavbarListDisplay(list: boolean) {
    this.changeNavbarList.next(list);
  }
}
