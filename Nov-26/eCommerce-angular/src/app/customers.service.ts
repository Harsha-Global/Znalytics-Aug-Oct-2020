import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
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
    return this.httpClient.post<CustomerViewModel>(
      `${this.urlPrefix}/api/Customers`,
      customer,
      { responseType: 'json' }
    );
  }

  getCustomerByCustomerName(
    customerName: string
  ): Observable<CustomerViewModel> {
    return this.httpClient.get<CustomerViewModel>(
      `${this.urlPrefix}/api/Customers?customerName=${customerName}`,
      { responseType: 'json' }
    );
  }
}
