import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LanguageService {

  private langCompanyName = new BehaviorSubject('soft');
  companyName = this.langCompanyName.asObservable();

  private langType = new BehaviorSubject('eng');
  lang = this.langType.asObservable();

  constructor() { }

  SetCompanyName(name: string) {
    return this.langCompanyName.next(name);
  }

  SetLanguage(language: string) {
    return this.langType.next(language);
  }
}
