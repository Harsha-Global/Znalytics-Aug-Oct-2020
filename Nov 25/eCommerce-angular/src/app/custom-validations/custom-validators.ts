import { Injectable } from '@angular/core';
import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

@Injectable({ providedIn: 'root' })
export class CustomValidatorsService {
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
}
