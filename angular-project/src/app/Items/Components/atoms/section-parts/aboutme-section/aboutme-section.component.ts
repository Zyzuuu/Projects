import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { LanguageService } from 'app/Items/Services/language-service/language.service';
import { ScrollService } from 'app/Items/Services/scroll/scroll.service';

@Component({
  selector: 'app-aboutme-section',
  templateUrl: './aboutme-section.component.html',
  styleUrls: ['./aboutme-section.component.scss']
})
export class AboutmeSectionComponent implements OnInit {
  @ViewChild('about') el: ElementRef;
  public content: string;

  constructor(private language: LanguageService,
    private scroll: ScrollService) { }

  ngOnInit(): void {
    this.scroll.SetAboutHeight(this.el.nativeElement.offsetHeight);
    this.language.lang.subscribe(lang => this.content = lang);
  }



}
