import { Injectable } from '@angular/core';
import { PostRequestService } from 'app/Items/Services/api-services/post/post-request.service';
import { ContactFormModel } from 'app/Items/Models/form-models/contact-form-model';
import { RootObjectError } from 'app/Items/Services/api-services/post/error';

@Injectable({
  providedIn: 'root'
})
export class ContactRequestService {

  constructor(private contactReq: PostRequestService) { }

  ContactRequest(param: ContactFormModel) {
    const body = new URLSearchParams();
    body.set('name', param.name);
    body.set('subject', param.subject);
    body.set('mail', param.mail);
    body.set('message', param.message);
    return this.contactReq.baseHttpOneHeader<RootObjectError>('/send_mail', body.toString());
  }
}
