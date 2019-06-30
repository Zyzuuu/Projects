import { Component, OnInit, ViewChild, ElementRef, Renderer2 } from '@angular/core';
import { ContactRequestService } from 'app/Items/Requests/contact-request/contact-request.service';
import { LanguageService } from 'app/Items/Services/language-service/language.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.component.html',
  styleUrls: ['./contact-form.component.scss'],

})
export class ContactFormComponent implements OnInit {
  public contactForm: FormGroup;
  public languageSwitch: string;
  public isSubmitted = false;
  public submessage = 'send';


  constructor(private contactReq: ContactRequestService,
    private language: LanguageService,
    private render: Renderer2) { }

  ngOnInit() {
    this.contactForm = new FormGroup({
      topic: new FormControl(null, Validators.required),
      name: new FormControl(null, Validators.required),
      email: new FormControl(null, Validators.required),
      message: new FormControl(null, Validators.required),
    });
    this.language.lang.subscribe(language => this.languageSwitch = language);
  }

  SubmitForm(form) {
    this.isSubmitted = true;
    if (form.valid) {
      this.contactReq.ContactRequest(form.value).subscribe(data => {
        if (data.error === 0) {
          this.SendButtonMessageStatus('sent', true);
          this.SendButtonMessageStatus('send', false);
          this.Reset();
        }
      });
    } else {
      this.SendButtonMessageStatus('error', true);
      this.SendButtonMessageStatus('send', false);
    }
  }

  SendButtonMessageStatus(message: string, flag: boolean) {
    if (flag) {
      this.submessage = message;
    } else {
      setTimeout(() => {
        this.submessage = message;
      }, 1000);
    }
  }

  Reset() {
    this.isSubmitted = false;
    this.contactForm.reset();
  }
}
