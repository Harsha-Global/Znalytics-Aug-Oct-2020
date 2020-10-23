import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from '../Models/product';
import { ProductsService } from '../products.service';

@Component({
  selector: 'app-edit-product',
  templateUrl: './edit-product.component.html',
  styleUrls: ['./edit-product.component.css']
})
export class EditProductComponent implements OnInit
{
  //step 1: Create property (cum reference variable) to store the reference of FormGroup
  myFormGroup: FormGroup;
  isFormSubmitted: boolean = false;

  //Constructor executes when the edit product page is opened. In this constructor, we are injecting service: ProductsService (means, object will be created for service classes)
  constructor(private productsService: ProductsService, private router: Router,
     private activatedRoute: ActivatedRoute)
  {
    //Create a new object of FormGroup class + creating 4 objects of FormControl class
    this.myFormGroup = new FormGroup({

      id: new FormControl(null,
        [Validators.required]),

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


    //receive parameter "id"
    this.activatedRoute.params
    .subscribe(
      (pr) => {
        console.log(pr.id); //represents actual value of the "id" parameter

        //send http request based on id i.e. received from ActivatedRoute service
        this.productsService.getProductByProductID(pr.id).subscribe(
          
          //handleData: executes when the response is received from server
          (response: Product[]) => {
            console.log(response);

            if (response.length == 0)
            {
              alert("Invalid Product ID");
            }

            else
            {
              this.myFormGroup.patchValue({
                id: response[0].id,
                productName: response[0].productName,
                brand: response[0].brand,
                price: response[0].price,
                isAvailable: response[0].isAvailable
              });
            }
          },
          
          //handleError
          (error) => {
            console.log(error);
          }

        );
      }
    );
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
      product.id = this.myFormGroup.value.id;
      product.productName = this.myFormGroup.value.productName;
      product.price = this.myFormGroup.value.price;
      product.brand = this.myFormGroup.value.brand;
      product.isAvailable = this.myFormGroup.value.isAvailable;

      //calling the service method and pass an object of Product class
      this.productsService.updateProduct(product)
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

      //this.productsService.updateProduct(this.myFormGroup.value);

      console.log("Save");
    }
  }
}
