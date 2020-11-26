import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  firstName: string = '';
  lastName: string = '';
  receiveNewsLetters: boolean = false;
  city: string = '';
  cities = ['Hyderabad', 'Chennai', 'Mumbai'];
}
