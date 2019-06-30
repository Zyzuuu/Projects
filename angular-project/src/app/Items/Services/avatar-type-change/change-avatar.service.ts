import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import * as avatarArrayInfo from 'app/Items/Models/arrays/types';

@Injectable({
  providedIn: 'root'
})
export class ChangeAvatarService {

  private avatarType = new BehaviorSubject(avatarArrayInfo.infoType[0].experience);
  avatar = this.avatarType.asObservable();

  constructor() { }

  SetAvatarType(type: string) {
    this.avatarType.next(type);
  }
}
