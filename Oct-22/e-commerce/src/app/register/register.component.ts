import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Router } from '@angular/router';
import { UsersService } from '../users.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit
{
  userName: string;
  password: string;
  newId: number;
  showId: boolean = false;
  isFormSubmitted: boolean = false;

  constructor(private httpClient: HttpClient, private router: Router, private usersService: UsersService)
  {
  }

  //HttpClient: Used to send HTTP requests
  //Router: Used to redirect to a specific route

  ngOnInit(): void
  {
  }

  onRegisterClick(regForm: NgForm)
  {
    this.isFormSubmitted = true;
    //if all the form elements are valid, then only we are sending request
    if (regForm.valid)
    {
      this.httpClient.post("http://localhost:3000/users",
      { username: this.userName, password: this.password })

      .subscribe(
        (response: any) =>
        {
          console.log(response);
          //alert(`Your id: ${response.id}`);
          this.newId = response.id;
          this.showId = true;

          //redirect to /home
          this.router.navigate(["/home"]);
          this.usersService.isLoggedIn = true;
        },

        (error) =>
        {
          console.log(error);
        }
      );
    }
    
  }
}
