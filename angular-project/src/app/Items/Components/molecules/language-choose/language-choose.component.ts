import { Component, OnInit } from '@angular/core';
import { Languages } from 'app/Items/Models/array-models/languages';

@Component({
  selector: 'app-language-choose',
  templateUrl: './language-choose.component.html',
  styleUrls: ['./language-choose.component.scss']
})
export class LanguageChooseComponent implements OnInit {

  public languages: Languages[] = [
    {
      src: 'assets/language-icons/Poland.png',
      language: 'pl'
    },
    {
      src: 'assets/language-icons/England.jpg',
      language: 'eng'
    }
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
