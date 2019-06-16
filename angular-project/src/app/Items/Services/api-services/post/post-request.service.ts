import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { RootObjectError } from './error';
import * as api from '../api-address';

@Injectable({
  providedIn: 'root'
})
export class PostRequestService {

  constructor(private http: HttpClient) { }


  baseHttpOneHeader<T extends RootObjectError>(endpoint, body) {

    const options = {
      headers: new HttpHeaders().set('Content-Type', 'application/x-www-form-urlencoded')
    };
    const post = this.http.post<T>(api.address + endpoint, body, options);

    return post;
  }
}
