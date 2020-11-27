import { HttpBackend, HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginViewModel } from './login-viewmodel';
import { User } from './user';
import { map } from 'rxjs/operators';

@Injectable({ providedIn: 'root' })
export class AccountService {
  urlPrefix: string = 'http://localhost:64543';
  private httpClient: HttpClient;

  constructor(private httpBackend: HttpBackend) {}

  login(loginViewModel: LoginViewModel): Observable<any> {
    this.httpClient = new HttpClient(this.httpBackend);

    return this.httpClient
      .post<User>(`${this.urlPrefix}/api/account/login`, loginViewModel, {
        responseType: 'json',
        observe: 'response',
      })
      .pipe(
        //executes after receiving response & but before handleData
        map((response) => {
          localStorage.token = response.headers.get('token');
          console.log(response.headers.get('token'));
          return response.body; //forward response body handleData
        })
      );
  }
}
