import { Component, HostListener } from '@angular/core';
import { MatDialog } from '@angular/material';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  constructor(private dialogRef: MatDialog) { }

  @HostListener('window:resize')
  onWindowResize(): void {
    if (window.innerWidth > 1023) {
      this.dialogRef.closeAll();
    }
  }

}
