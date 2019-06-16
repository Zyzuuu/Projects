import { Injectable, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import * as navLinkArray from 'app/Items/Models/arrays/navbar-links-array';

@Injectable({
  providedIn: 'root'
})
export class ScrollService implements OnInit {
  aboutHeight: number;
  private navBar = new BehaviorSubject(false);
  navbarTransparency = this.navBar.asObservable();
  private active = new BehaviorSubject(navLinkArray.navLinks[4].name);
  activeLink = this.active.asObservable();
  private aboutMe = new BehaviorSubject(0);
  about = this.aboutMe.asObservable();
  private projects = new BehaviorSubject(0);
  projectsH = this.aboutMe.asObservable();
  private home = new BehaviorSubject(0);
  homeH = this.aboutMe.asObservable();
  private contact = new BehaviorSubject(0);
  contactH = this.aboutMe.asObservable();
  private skills = new BehaviorSubject(0);
  skillsH = this.aboutMe.asObservable();

  constructor() { }
  ngOnInit(): void {
  }
  SetActiveLink(active: string) {
    this.active.next(active);
  }
  SetNavbarTransparency(transparent: boolean) {
    this.navBar.next(transparent);
  }
  SetAboutHeight(value: number) {
    this.aboutMe.next(value);
  }
  SetProjectsHeight(value: number) {
    this.projects.next(value);
  }
  SetHomeHeight(value: number) {
    this.home.next(value);
  }
  SetContactHeight(value: number) {
    this.contact.next(value);
  }
  SetSkillsHeight(value: number) {
    this.skills.next(value);
  }


  ScrollDetect(): void {
    const offSet = window.pageYOffset,
      height = window.innerHeight,
      scrolledPercentage = (offSet / height) * 100;

    if (scrolledPercentage === 0) {
      this.SetNavbarTransparency(false);
    } else {
      this.SetNavbarTransparency(true);
    }
    if (scrolledPercentage < 90) {
      this.SetActiveLink(navLinkArray.navLinks[4].name);
    }
    if (scrolledPercentage > 90 && scrolledPercentage < 150) {
      this.SetActiveLink(navLinkArray.navLinks[0].name);
    }
    if (scrolledPercentage > 204 && scrolledPercentage < 250) {
      this.SetActiveLink(navLinkArray.navLinks[1].name);
    }
    if (scrolledPercentage >= 305 && scrolledPercentage < 350) {
      this.SetActiveLink(navLinkArray.navLinks[2].name);
    }
    if (scrolledPercentage > 399) {
      this.SetActiveLink(navLinkArray.navLinks[3].name);
    }
  }
}
