import { Component } from '@angular/core';

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
  styleUrls: [ "./home.component.css" ]
})
export class HomeComponent
{
  categories = [ "Electronics", "Home Appliances", "Mobiles", "Fashion" ];

  products = [
    { productId: 101, productName: "abc", cost: 9500, dateOfManufacture: new Date("2007-09-10T15:10") },
    { productId: 102, productName: "def", cost: 2400, dateOfManufacture: new Date("2015-10-19T12:07") },
    { productId: 103, productName: "ghi", cost: 7700, dateOfManufacture: new Date("2020-03-23T09:20") },
  ];
}

