import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

@Injectable({ providedIn: 'root' })
export class SpecificDialogBox {

    constructor(private openDialogBox: MatDialog) { }

    OpenSpecificDialogBox(matDialogComponentName, widthpx, heightpx) {
        const dialog = this.openDialogBox.open(matDialogComponentName,
            {
                width: widthpx,
                height: heightpx,
            });

        return dialog;
    }
}
