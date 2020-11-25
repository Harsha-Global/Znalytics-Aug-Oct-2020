import { Component } from '@angular/core';
import { CustomersService } from '../customers.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CustomValidatorsService } from '../custom-validations/custom-validators';

@Component({
  selector: 'new-customer',
  templateUrl: './new-customer.component.html',
  styleUrls: ['./new-customer.component.scss'],
})
export class NewCustomerComponent {
  newForm: FormGroup;

  constructor(
    private customersService: CustomersService,
    private customValidatorsService: CustomValidatorsService
  ) {
    var d: Date = new Date();
    var dt = d.getFullYear() + '-' + (d.getMonth() + 1) + '-' + d.getDate();

    this.newForm = new FormGroup({
      CustomerName: new FormControl(null, [Validators.required]),
      DateOfJoining: new FormControl(dt, [
        customValidatorsService.validateMinDate(),
      ]),
    });
  }

  ngOnInit() {}

  onSaveClick() {
    if (this.newForm.valid) {
      this.customersService.insertCustomer(this.newForm.value).subscribe(
        //handleData
        (response) => {
          console.log(response);
        },

        //handleError
        (error) => {
          console.log(error);
        }
      );
    }
  }
}
