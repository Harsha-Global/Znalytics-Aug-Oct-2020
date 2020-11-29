import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login-component/login.component';
import { NewCustomerComponent } from './new-customer/new-customer.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'new-customer', component: NewCustomerComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
