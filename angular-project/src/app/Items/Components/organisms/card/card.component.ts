import { Component, OnInit } from '@angular/core';
import { LanguageService } from 'app/Items/Services/language-service/language.service';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {

  public languageSwitch: string;
  public companyName: string;

  constructor(private language: LanguageService) { }

  ngOnInit() {
    this.language.companyName.subscribe(company => this.companyName = company);
    this.language.lang.subscribe(lang => this.languageSwitch = lang);
  }
}
