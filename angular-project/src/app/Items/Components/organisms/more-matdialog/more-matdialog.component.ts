import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material';


@Component({
  selector: 'app-more-matdialog',
  templateUrl: './more-matdialog.component.html',
  styleUrls: ['./more-matdialog.component.scss']
})
export class MoreMatdialogComponent implements OnInit {

  constructor(public dialog: MatDialogRef<MoreMatdialogComponent>) { }

  ngOnInit() {
  }
  Close() {
    this.dialog.close();
  }
}
