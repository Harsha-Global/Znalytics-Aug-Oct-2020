import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from './Models/product';
import { Observable, pipe } from "rxjs";
import { map } from "rxjs/operators";

@Injectable()
export class ProductsService
{
  private base: string = "http://localhost:3000";

  constructor(private httpClient: HttpClient)
  {
  }

  //This method receives an object of Product class (Product type) that includes all properties of Product class
  insertProduct(product: Product): Observable<Product>
  {
    return this.httpClient.post<Product>(`${this.base}/products`,
      product, { responseType: "json" });
  }

  //This method receives an object of Product class (Product type) that includes all properties of Product class
  updateProduct(product: Product): Observable<Product>
  {
    return this.httpClient.put<Product>(`${this.base}/products/${product.id}`,
      product, { responseType: "json" });
  }

  //This method receives "id"
  getProductByProductID(id: number): Observable<Product[]>
  {
    return this.httpClient.get<Product[]>(`${this.base}/products?id=${id}`,
      { responseType: "json" });
  }

  //This method receives "id"
  deleteProduct(id: number): Observable<Product[]>
  {
    return this.httpClient.delete<Product[]>(`${this.base}/products/${id}`,
      { responseType: "json" });
  }

  //This method receives nothing
  getAllProducts(): Observable<Product[]>
  {
    return this.httpClient.get<Product[]>(`${this.base}/products`,
      { responseType: "json" })
      
      .pipe(map(
        (products: Product[]) =>
        {
          products.map(prod =>
          {
            prod.discount = prod.price * 10 / 100;
          });
          console.log(products);
          return products;
        }
      ));
  }

  //This method receives brand name
  getProductsByBrand(brand: string): Observable<Product[]>
  {
    return this.httpClient.get<Product[]>(`${this.base}/products?brand=${brand}`,
      { responseType: "json" });
  }

  //This method receives product name
  getProductsByProductName(productName: string): Observable<Product[]>
  {
    return this.httpClient.get<Product[]>(`${this.base}/products?productName=${productName}`,
      { responseType: "json" });
  }

} //closing the class
