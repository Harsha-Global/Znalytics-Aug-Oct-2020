import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit
{
  userName: string;
  password: string;

  constructor(private httpClient: HttpClient)
  {
  }

  ngOnInit(): void
  {
  }

  onRegisterClick()
  {
    this.httpClient.post("http://localhost:3000/users", 
    { username: this.userName, password: this.password })

    .subscribe(
      (response: any) => {
        console.log(response);
        alert(`Your id: ${response.id}`);
      },

      (error) =>
      {
        console.log(error);
      }
    );
  }
}
