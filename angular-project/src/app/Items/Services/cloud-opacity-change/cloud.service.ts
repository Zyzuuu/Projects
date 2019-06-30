import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CloudService {

  private changeCloud = new BehaviorSubject(false);
  cloud = this.changeCloud.asObservable();

  constructor() { }

  SetCloudStatus(status: boolean): void {
    this.changeCloud.next(status);
  }
}
