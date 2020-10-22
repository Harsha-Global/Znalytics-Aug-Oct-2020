import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from "@angular/forms";

@Component({
  selector: 'app-new-product',
  templateUrl: './new-product.component.html',
  styleUrls: ['./new-product.component.css']
})
export class NewProductComponent implements OnInit
{
  //step 1: Create property (cum reference variable) to store the reference of FormGroup
  myFormGroup: FormGroup;

  constructor(private httpClient: HttpClient)
  {
    //Create a new object of FormGroup class + creating 4 objects of FormControl class
    this.myFormGroup = new FormGroup({

      productName: new FormControl(null, 
        [ Validators.required, 
          Validators.minLength(2), 
          Validators.maxLength(40), 
          Validators.pattern('^[A-Za-z .]*$') ]),

      price: new FormControl(null, 
        [ Validators.required, 
          Validators.pattern('^[0-9.]*$'),
          Validators.min(0),
          Validators.max(100000) ]),

      brand: new FormControl("", [ Validators.required ]),

      isAvailable: new FormControl(false)
    });
  }

  ngOnInit(): void
  {
  }

  //Executes when the user clicks on the Save button
  onSaveClick()
  {
    console.log("Save");
  }
} //closing of class
