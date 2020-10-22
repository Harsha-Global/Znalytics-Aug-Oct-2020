import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from '../Models/product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit
{
  //properties
  products: Product[] = [];
  selectedBrand: string = "";
  searchProduct: string = "";

  //constructor
  constructor(private httpClient: HttpClient)
  {
  }

  ngOnInit(): void
  {
    //send request to get products
    this.httpClient.get<Product[]>("http://localhost:3000/products", { responseType: "json" })
      .subscribe(

        (response) =>
        {
          this.products = response;
        },

        (error) =>
        {
          console.log(error);
        }
      );
  }

  onBrandChange()
  {
    let url = null;
    if (this.selectedBrand == "") //All
    {
      url = "http://localhost:3000/products";
    }
    else
    {
      url = `http://localhost:3000/products?brand=${this.selectedBrand}`;
    }

    //send request to get products
    this.httpClient.get<Product[]>(url, { responseType: "json" })
      .subscribe(

        (response) =>
        {
          this.products = response;
        },

        (error) =>
        {
          console.log(error);
        }
      );
  }


  //Executes when the user clicks on Search button
  onSearchClick()
  {
    //send request
    this.httpClient.get<Product[]>(`http://localhost:3000/products?productName=/${this.searchProduct}/`, { responseType: "json" })
      .subscribe(
        (response) => { 
          this.products = response;
        },

        (error) =>
        {
          console.log(error);
        }
      );
  }
}
