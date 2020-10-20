import { Component } from '@angular/core';
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { Employee } from "../../models/employee";

@Component({
  selector: "app-contact",
  templateUrl: "./contact.component.html",
  styleUrls: [ "./contact.component.css" ]
})
export class ContactComponent
{
  searchEmpName = null;
  employees = [];

  //it executes when an object is created for the current class.
  constructor(private httpClient: HttpClient)
  {
    var myObservable : Observable<Employee[]> = httpClient.get<Employee[]>(`http://localhost:3000/employees`, { responseType: "json" });

    myObservable.subscribe(
      
      //handleData
      (emps: Employee[]) => { 
        this.employees = emps;
      },

      //handleError
      (error) => { console.log("handleError"); }
    );
  }

  onSearchClick()
  {
    var myObservable : Observable<Employee[]> = this.httpClient.get<Employee[]>(`http://localhost:3000/employees?empName=${this.searchEmpName}`, { responseType: "json" });

    myObservable.subscribe(
      
      //handleData
      (emps: Employee[]) => { 
        this.employees = emps;
      },

      //handleError
      (error) => { console.log("handleError"); }
    );
  }
}
