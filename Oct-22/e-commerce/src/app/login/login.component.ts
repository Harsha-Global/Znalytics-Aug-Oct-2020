import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Router } from '@angular/router';
import { UsersService } from '../users.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit
{
  userName: string;
  password: string;
  showError: boolean = false;

  constructor(private httpClient: HttpClient, private router: Router, private usersService: UsersService)
  {
  }

  //HttpClient: Used to send HTTP requests
  //Router: Used to redirect to a specific route

  ngOnInit(): void
  {
  }

  onLoginClick()
  {
    this.httpClient.get(`http://localhost:3000/users?username=${this.userName}&password=${this.password}`)

      .subscribe(
        (response: any) =>
        {
          console.log(response);
          if (response.length == 0)
          {
            //invalid login as the response array is empty array
            //alert("Invalid login, please try again");
            this.showError = true; //invalid
          }
          else
          {
            //redirect to /home
            this.router.navigate(["/home"]);
            this.usersService.isLoggedIn = true;
            this.showError = false; //invalid
          }
        },

        (error) =>
        {
          console.log(error);
        }
      );
  }

}
