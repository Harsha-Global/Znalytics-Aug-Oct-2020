import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EditProductComponent } from './edit-product/edit-product.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { NewProductComponent } from './new-product/new-product.component';
import { ProductsComponent } from './products/products.component';
import { RegisterComponent } from './register/register.component';

const routes: Routes = [
  { path: "home", component: HomeComponent },
  { path: "register", component: RegisterComponent },
  { path: "login", component: LoginComponent },
  { path: "products", component: ProductsComponent },
  { path: "new-product", component: NewProductComponent },
  { path: "edit-product/:id", component: EditProductComponent },
  { path: "", pathMatch: "full", redirectTo: "/home" },
  { path: "**", redirectTo: "/home" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }