import { Directive } from '@angular/core';
import {
  AbstractControl,
  NG_VALIDATORS,
  ValidationErrors,
  Validator,
} from '@angular/forms';

@Directive({
  selector: 'dateOfJoiningValidator',
  providers: [
    {
      provide: NG_VALIDATORS,
      useExisting: DateOfJoiningValidator,
      multi: true,
    },
  ],
})
export class DateOfJoiningValidator implements Validator {
  validate(control: AbstractControl): ValidationErrors | null {
    var dt = new Date(control.value); //YYYY-MM-dd to Date object
    var dt2000 = new Date('2000-01-01');

    if (dt.getTime() > dt2000.getTime()) {
      return null; //valid
    } else {
      return { mindate: { valid: false } }; //invalid
    }
  }
}
