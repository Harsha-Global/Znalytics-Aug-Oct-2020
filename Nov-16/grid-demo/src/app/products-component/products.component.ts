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
        this.products = response;
      },
      //handleData ends

      (error) => {
        console.log(error);
      }
    );
  } //end of ngOnInit

  //Executes when the user clicks on any one column name
  onColumnClick(columnName: string) {
    this.sortBy = columnName;

    //Switch from ASC to DESC; and vice versa
    if (this.sortOrder == 'ASC') {
      this.sortOrder = 'DESC';
    } else {
      this.sortOrder = 'ASC';
    }
  }
} //end of class
