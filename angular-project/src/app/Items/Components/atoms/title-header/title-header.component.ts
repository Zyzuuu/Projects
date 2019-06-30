import { Component, OnInit, Input } from '@angular/core';
import { LanguageService } from 'app/Items/Services/language-service/language.service';

@Component({
  selector: 'app-title-header',
  templateUrl: './title-header.component.html',
  styleUrls: ['./title-header.component.scss']
})
export class TitleHeaderComponent implements OnInit {

  @Input() dictionary: string;
  @Input() fontsize: string;
  @Input() fontcolor: string;
  @Input() shadow: boolean;
  @Input() case: string;
  public headerText: string;

  constructor(private language: LanguageService) { }

  ngOnInit(): void {
    this.language.lang.subscribe(lang => this.headerText = lang);
  }


}
