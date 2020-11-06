import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Product } from './Product';

@Injectable({ providedIn: "root"})
export class SampleService
{
  constructor(private httpClient: HttpClient)
  {
  }

  getProducts(): Observable<Product[]>
  {
    return this.httpClient.get<Product[]>("http://localhost:50305/api/Products");
  }
}


