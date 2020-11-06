import { Component } from '@angular/core';
import { SampleService } from './sample.service';

@Component({
  selector: "harsha",
  templateUrl: "./app.component.html",
  styleUrls: [ "./app.component.css" ]
})
export class AppComponent
{
  customerID: number = 201;
  customerName: string = "Scott";
  age: number = 20;

  constructor(private sampleService: SampleService)
  {
  }

  ngOnInit()
  {
    this.sampleService.getProducts().subscribe(
      (response) => {
        console.log(response);
      },

      (error) => {
        console.log(error);
      }
    );
  }
}
