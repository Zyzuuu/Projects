import { Component, OnInit, Input } from '@angular/core';
import { Languages } from 'app/Items/Models/array-models/languages';
import { LanguageService } from 'app/Items/Services/language-service/language.service';

@Component({
  selector: 'app-language',
  templateUrl: './language.component.html',
  styleUrls: ['./language.component.scss']
})
export class LanguageComponent implements OnInit {

  @Input() languages: Languages[];
  constructor(private language: LanguageService) { }

  ngOnInit(): void {
  }

  SetLanguage(language: string) {
    this.language.SetLanguage(language);
  }

}
