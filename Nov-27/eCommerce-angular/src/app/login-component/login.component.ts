import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AccountService } from '../account.service';
import { LoginViewModel } from '../login-viewmodel';
import { User } from '../user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent {
  loginForm: FormGroup;
  message: string;

  constructor(private accountService: AccountService) {
    this.loginForm = new FormGroup({
      email: new FormControl('scott@gmail.com', [Validators.required]),
      password: new FormControl('scott123', [Validators.required]),
    });
  }

  ngOnInit() {}

  onLoginClick() {
    if (this.loginForm.valid) {
      //create object of LoginViewModel
      var loginVM = new LoginViewModel();
      loginVM.Email = this.loginForm.value.email;
      loginVM.Password = this.loginForm.value.password;

      this.accountService.login(loginVM).subscribe(
        //handleData
        (response: any) => {
          if (response) {
            //login valid
            this.message = `Welcome to ${response.FullName}`;
          } else {
            //login invalid
            this.message = 'Invalid Login, please try again';
          }
        },

        //handleError
        () => {}
      );
    }
  }
}
