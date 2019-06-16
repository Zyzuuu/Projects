import { Component, OnInit, ViewChild } from '@angular/core';
import { ContactRequestService } from 'app/Items/Requests/contact-request/contact-request.service';
import { NgForm } from '@angular/forms';
import { LanguageService } from 'app/Items/Services/language-service/language.service';

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.component.html',
  styleUrls: ['./contact-form.component.scss']
})
export class ContactFormComponent implements OnInit {

  @ViewChild('form') form: NgForm;
  languageSwitch: string;
  field = new FormInputs();

  constructor(private contactReq: ContactRequestService,
    private language: LanguageService) { }

  ngOnInit() {
    this.language.lang.subscribe(language => this.languageSwitch = language);
  }

  SubmitForm() {
    this.contactReq.ContactRequest(this.field).subscribe(data => {
      if (data.error === 0) {
        this.form.resetForm();
      }
    });
  }
}

export class FormInputs {
  constructor(
    public subject = null,
    public mail = null,
    public name = null,
    public message = null,
  ) { }
}
