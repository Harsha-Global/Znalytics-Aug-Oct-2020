import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { Router } from '@angular/router';
import { Product } from '../Models/product';
import { ProductsService } from '../products.service';

@Component({
  selector: 'app-new-product',
  templateUrl: './new-product.component.html',
  styleUrls: ['./new-product.component.css']
})
export class NewProductComponent implements OnInit
{
  //step 1: Create property (cum reference variable) to store the reference of FormGroup
  myFormGroup: FormGroup;
  isFormSubmitted: boolean = false;

  //Constructor executes when the new product page is opened. In this constructor, we are injecting service: ProductsService (means, object will be created for service classes)
  constructor(private productsService: ProductsService, private router: Router)
  {
    //Create a new object of FormGroup class + creating 4 objects of FormControl class
    this.myFormGroup = new FormGroup({

      productName: new FormControl(null,
        [Validators.required,
        Validators.minLength(2),
        Validators.maxLength(40),
        Validators.pattern('^[A-Za-z .]*$')]),

      price: new FormControl(null,
        [Validators.required,
        Validators.pattern('^[0-9.]*$'),
        Validators.min(0),
        Validators.max(100000)]),

      brand: new FormControl("", [Validators.required]),

      isAvailable: new FormControl(false)
    });
  }

  ngOnInit(): void
  {
  }

  //Executes when the user clicks on the Save button
  onSaveClick()
  {
    this.isFormSubmitted = true;

    if (this.myFormGroup.valid)
    {
      //create an object for Product class
      var product = new Product();

      //reading (getting) values from textboxes (form controls)
      product.productName = this.myFormGroup.value.productName;
      product.price = this.myFormGroup.value.price;
      product.brand = this.myFormGroup.value.brand;
      product.isAvailable = this.myFormGroup.value.isAvailable;

      //calling the service method and pass an object of Product class
      this.productsService.insertProduct(product)
      .subscribe(

        //handleData: executes up on receiving response successfully (statusCode: 200)
        (response: Product) => {
          console.log(response); //You can access id and other properties of Product here
          this.router.navigate([ "/products"]); //go to products
        },

        //handleError: executes up on receiving error response (statusCode: 400 or 500)
        (error) => {
          console.log(error);
        }
      );

      //this.productsService.insertProduct(this.myFormGroup.value);

      console.log("Save");
    }
  }
} //closing of class
