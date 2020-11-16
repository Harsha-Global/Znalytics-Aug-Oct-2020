import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/product';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class ProductsService {
  urlPrefix: string = 'http://localhost:50580';

  constructor(private httpClient: HttpClient) {}

  //Sending "get" request to fetch an array of products
  getProducts(): Observable<Product[]> {
    return this.httpClient.get<Product[]>(this.urlPrefix + '/api/Products', {
      responseType: 'json',
    });
  }
}
