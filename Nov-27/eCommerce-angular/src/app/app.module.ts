import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NewCustomerComponent } from './new-customer/new-customer.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './login-component/login.component';

@NgModule({
  declarations: [AppComponent, NewCustomerComponent, LoginComponent],

  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
  ],

  providers: [],

  bootstrap: [AppComponent],
})
export class AppModule {}
