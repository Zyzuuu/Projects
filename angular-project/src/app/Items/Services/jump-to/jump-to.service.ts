import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class JumpToService {

  constructor() { }

  scroll(anchor: string) {
    const height = window.innerHeight;

    if (anchor === '#home') {
      window.scrollTo(0, 0);
    }
    if (anchor === '#about') {
      window.scrollTo(0, height);
    }
    if (anchor === '#skills') {
      window.scrollTo(0, height * 2);
    }
    if (anchor === '#projects') {
      window.scrollTo(0, height * 3);
    }
    if (anchor === '#contact') {
      window.scrollTo(0, height * 4);
    }
  }
}
