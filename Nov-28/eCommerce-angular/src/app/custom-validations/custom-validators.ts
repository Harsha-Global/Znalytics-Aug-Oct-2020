import { Injectable } from '@angular/core';
import {
  AbstractControl,
  AsyncValidatorFn,
  ValidationErrors,
  ValidatorFn,
} from '@angular/forms';
import { CustomersService } from '../customers.service';
import { map } from 'rxjs/operators';
import { CustomerViewModel } from '../CustomerViewModel';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class CustomValidatorsService {
  //constructor
  constructor(private customersService: CustomersService) {}

  //method for validation of min date
  public validateMinDate(): ValidatorFn {
    //return an arrow function that performs actual validation
    return (control: AbstractControl): ValidationErrors | null => {
      var dt = new Date(control.value); //YYYY-MM-dd to Date object
      var dt2000 = new Date('2000-01-01');

      if (dt.getTime() > dt2000.getTime()) {
        return null; //valid
      } else {
        return { mindate: { valid: false } }; //invalid
      }
    };
  }

  //method for validation of customer name
  public validateCustomerName(): AsyncValidatorFn {
    //return an arrow function that performs actual validation
    return (control: AbstractControl): Observable<ValidationErrors | null> => {
      return this.customersService
        .getCustomerByCustomerName(control.value)
        .pipe(
          map((customerVM: CustomerViewModel) => {
            //we can check whether the customer view model is received or not
            if (customerVM != null) {
              //exists; invalid
              return { duplicate: { valid: false } }; //invalid
            } else {
              //not exists; valid
              return null;
            }
          })
        );
    };
  }
}
