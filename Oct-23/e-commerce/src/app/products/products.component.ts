import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from '../Models/product';
import { ProductsService } from '../products.service';

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
  constructor(private httpClient: HttpClient, private productsService: ProductsService)
  {
  }

  ngOnInit(): void
  {
    //send request to get products
    this.productsService.getAllProducts()
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

  //This method executes when the user selects a brand in the dropdownlist
  onBrandChange()
  {
    let myObservable;
    if (this.selectedBrand == "") //All
    {
      myObservable = this.productsService.getAllProducts();
    }
    else
    {
      myObservable = this.productsService.getProductsByBrand(this.selectedBrand);
    }

    //send request to get all products (or) get products by brand
    myObservable
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
    this.productsService.getProductsByProductName(this.searchProduct)
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

  //Executes when the user clicks on Delete button
  onDeleteClick(product: Product)
  {
    //console.log(`delete ${product.id}`);
    if (confirm(`Are you sure to delete ${product.productName}?`))
    {
      this.productsService.deleteProduct(product.id)
        .subscribe(

          (response) =>
          {
            console.log(response);

            //get index of deleted product based on "id"
            let indexOfDeletedProduct = this.products.findIndex(
              (prod) => { return prod.id == product.id }
            );

            //delete product object from the "products" array
            this.products.splice(indexOfDeletedProduct, 1);
          },

          (error) =>
          {
            console.log(error);
          }

        );
    }
  }
} //closing the class
