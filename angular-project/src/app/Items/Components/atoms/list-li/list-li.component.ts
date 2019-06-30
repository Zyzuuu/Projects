import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-list-li',
  templateUrl: './list-li.component.html',
  styleUrls: ['./list-li.component.scss']
})
export class ListLiComponent implements OnInit {

  @Input() data: any[];
  @Input() paddingleft: string;
  @Input() paddingtop: string;

  constructor() { }

  ngOnInit() {
  }

}
