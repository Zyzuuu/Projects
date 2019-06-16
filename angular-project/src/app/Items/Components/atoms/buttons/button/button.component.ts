import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { LanguageService } from 'app/Items/Services/language-service/language.service';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.scss']
})
export class ButtonComponent implements OnInit {

  @Input() buttonText: string;
  @Input() dictionary: string;
  @Output() click = new EventEmitter;

  constructor(private language: LanguageService) { }

  ngOnInit(): void {
    this.language.lang.subscribe(lang => this.buttonText = lang);
  }

  ClickFunction(): void {
    this.click.emit();
  }

}
