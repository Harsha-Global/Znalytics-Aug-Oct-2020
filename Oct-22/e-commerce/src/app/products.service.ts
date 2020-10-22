import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from './Models/product';
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class ProductsService
{
  constructor(private httpClient: HttpClient)
  {
  }

  //This method receives an object of Product class (Product type) that includes all properties of Product class
  insertProduct(product: Product): Observable<Product>
  {
    return this.httpClient.post<Product>("http://localhost:3000/products",
    product, { responseType: "json"});
  }
}
