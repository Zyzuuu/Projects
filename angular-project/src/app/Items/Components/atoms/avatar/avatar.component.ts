import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-avatar',
  templateUrl: './avatar.component.html',
  styleUrls: ['./avatar.component.scss']
})
export class AvatarComponent implements OnInit {

  @Input() source: string;
  @Input() width: string;
  @Input() height: string;
  @Input() background: string;
  @Input() border: string;
  @Input() borderradius: string;
  @Input() avatarText: string;
  @Input() opacity: string;
  @Input() index: string;

  constructor() { }

  ngOnInit(): void {
  }

}
