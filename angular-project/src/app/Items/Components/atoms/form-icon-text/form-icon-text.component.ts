import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-form-icon-text',
  templateUrl: './form-icon-text.component.html',
  styleUrls: ['./form-icon-text.component.scss']
})
export class FormIconTextComponent implements OnInit {
  @Input() text: string;
  @Input() source: string;
  constructor() { }

  ngOnInit() {
  }

}
