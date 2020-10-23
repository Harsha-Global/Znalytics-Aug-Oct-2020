import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit
{
  //Input: We are ready to accept value from the parent component
  @Input() phone: string;

  constructor() { }

  ngOnInit(): void
  {
  }
}
