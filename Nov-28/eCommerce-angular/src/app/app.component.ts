import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from './account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  constructor(public accountService: AccountService, private router: Router) {}

  onLogOutClick() {
    this.accountService.isLoggedIn = false; //update the status of login in the service

    localStorage.removeItem('token'); //remove the token from localStorage

    this.router.navigate(['/login']);
  }
}
