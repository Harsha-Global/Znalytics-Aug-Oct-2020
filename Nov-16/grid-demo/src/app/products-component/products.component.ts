import { Component } from '@angular/core';
import { Product } from '../models/product';
import { ProductsService } from '../services/products.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css'],
})
export class ProductsComponent {
  products: Product[] = [];
  sortBy: string = 'productName';
  sortOrder: string = 'ASC'; //ASC | DESC

  constructor(private productsService: ProductsService) {}

  ngOnInit() {
    this.productsService.getProducts().subscribe(
      //handleData starts
      (response: Product[]) => {
        //less than 0        :   a comes before b
        //greater than 0  :   b comes before a
        //equal to 0         :   a and b are left unchanged

        this.sort(response);
      },
      //handleData ends

      (error) => {
        console.log(error);
      }
    );
  }

  sort(response: Product[]) {
    response.sort((a, b) => {
      //checking whether both arguments are truthy values: not null, not undefined, not 0, not ""
      if (a[this.sortBy] && b[this.sortBy]) {
        //store values to compare in two variables
        let firstValue = a[this.sortBy];
        let secondValue = b[this.sortBy];

        //checking data type of column value
        if (typeof firstValue == 'string' && typeof secondValue == 'string') {
          firstValue = firstValue[0].toString().toLowerCase();
          secondValue = secondValue[0].toString().toLowerCase();
        }

        if (firstValue < secondValue) {
          return -1;
        } else if (firstValue > secondValue) {
          return 1;
        } else {
          return 0;
        }
      } else {
        return 0;
      }
    });
    //end of sort() method

    if (this.sortOrder == 'DESC') {
      response = response.reverse();
    }

    console.log(response); //sorted

    this.products = response;
  } //end of sort
} //end of class
