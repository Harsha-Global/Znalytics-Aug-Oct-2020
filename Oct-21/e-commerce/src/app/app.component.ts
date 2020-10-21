import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UsersService } from './users.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent
{
  constructor(public usersService: UsersService, private router: Router)
  {

  }

  onLogoutClick()
  {
    this.usersService.isLoggedIn = false;
    this.router.navigate( [ "/home" ] );
  }
}
