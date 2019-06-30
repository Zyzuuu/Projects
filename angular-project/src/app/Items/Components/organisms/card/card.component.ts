import { Component, OnInit } from '@angular/core';
import { LanguageService } from 'app/Items/Services/language-service/language.service';
import { ChangeAvatarService } from 'app/Items/Services/avatar-type-change/change-avatar.service';
import * as avatarTypeArray from 'app/Items/Models/arrays/types';
import * as softIntExperienceArray from 'app/Items/Models/arrays/language-arrays/soft-int-lang-array';
import * as szlipsIntExperienceArray from 'app/Items/Models/arrays/language-arrays/szlips-lang-array';
import * as maurIntExperienceArray from 'app/Items/Models/arrays/language-arrays/maur-lang-array';
import * as polslIntExperienceArray from 'app/Items/Models/arrays/language-arrays/polsl-lang-array';
@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {

  public languageSwitch: string;
  public companyName: string;
  public infoAvatarSource: string;
  public softintExperience: any[] = [];

  constructor(private language: LanguageService, private avatar: ChangeAvatarService) { }

  ngOnInit() {
    this.language.companyName.subscribe(company => {
      this.language.lang.subscribe(lang => {
        this.companyName = company;
        this.languageSwitch = lang;
        this.SwitchLanguageSource(company, lang);
      });
    });
    this.CheckTypeAndChangeAvatar();
  }

  SwitchLanguageSource(place: string, language: string) {
    switch (place) {
      case 'soft':
        this.LanguageReturn(language, softIntExperienceArray.plArray, softIntExperienceArray.engArray, 'pl');
        break;
      case 'szlips':
        this.LanguageReturn(language, szlipsIntExperienceArray.plArray, szlipsIntExperienceArray.engArray, 'pl');
        break;
      case 'maur':
        this.LanguageReturn(language, maurIntExperienceArray.plArray, maurIntExperienceArray.engArray, 'pl');
        break;
      case 'polsl':
        this.LanguageReturn(language, polslIntExperienceArray.plArray, polslIntExperienceArray.engArray, 'pl');
        break;
      default:
        this.LanguageReturn(language, [], [], 'pl');
        break;
    }
  }

  LanguageReturn(language: string, arr: any, arr2: any, mainLanguage: string) {
    if (language === mainLanguage) {
      this.softintExperience = arr;
    } else {
      this.softintExperience = arr2;
    }
  }

  CheckTypeAndChangeAvatar() {
    this.avatar.avatar.subscribe(type => {
      switch (type) {
        case avatarTypeArray.infoType[0].education:
          this.infoAvatarSource = 'assets/icons/work/education.png';
          break;
        case avatarTypeArray.infoType[0].experience:
          this.infoAvatarSource = 'assets/icons/work/skill-11-1167391.png';
          break;
      }
    });
  }
}
