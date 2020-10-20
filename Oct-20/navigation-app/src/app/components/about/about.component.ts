import { Component } from '@angular/core';
import { Observable, from } from "rxjs";

@Component({
  selector: "app-home",
  templateUrl: "./about.component.html",
  styleUrls: ["./about.component.css"]
})
export class AboutComponent
{
  constructor()
  {
    //Observable
    var myObservable : Observable<number> = from([ 10, 20, 30, 40, 50]); //the "from" function creates and returns an observable; and we are receiving it into a variable called myObservable.

    myObservable.subscribe(
      (n) => { console.log(`handleData ${n}`); },
      (error) => { console.log("handleError"); },
      () => { console.log("onComplete"); }
    );
  }
}
