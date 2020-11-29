import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { InsertCustomerViewModel } from './InsertCustomerViewModel';
import { CustomerViewModel } from './CustomerViewModel';

@Injectable({ providedIn: 'root' })
export class CustomersService {
  urlPrefix: string = 'http://localhost:64543';

  constructor(private httpClient: HttpClient) {}

  insertCustomer(
    customer: InsertCustomerViewModel
  ): Observable<CustomerViewModel> {
    //create request header
    // let headers = new HttpHeaders();
    // headers = headers.set('Authorization', `Bearer ${localStorage.token}`);

    return this.httpClient.post<CustomerViewModel>(
      `${this.urlPrefix}/api/Customers`,
      customer,
      {
        responseType: 'json',
        //headers: headers
      }
    );
  }

  getCustomerByCustomerName(
    customerName: string
  ): Observable<CustomerViewModel> {
    //create request header
    // let headers = new HttpHeaders();
    // headers = headers.set('Authorization', `Bearer ${localStorage.token}`);

    return this.httpClient.get<CustomerViewModel>(
      `${this.urlPrefix}/api/Customers?customerName=${customerName}`,
      { responseType: 'json' }
    );
  }
}

//recommended: HTTP interceptors
