import { Directive, HostListener, ElementRef } from '@angular/core';
import { CloudService } from '../Services/cloud-opacity-change/cloud.service';

@Directive({
  selector: '[appCloudsChange]'
})
export class CloudsChangeDirective {
  aTouched;
  constructor(private el: ElementRef, private cloudStatus: CloudService) { }

  @HostListener('mouseenter', ['$event']) changeCloudOnMouseEnter(): void {
    this.aTouched = this.el.nativeElement;
    if (this.aTouched) {
      this.cloudStatus.SetCloudStatus(true);
    }
  }
  @HostListener('mouseleave', ['$event']) changeCloudOnMouseLeave(): void {
    this.aTouched = this.el.nativeElement;
    if (this.aTouched) {
      this.cloudStatus.SetCloudStatus(false);
    }
  }

}
