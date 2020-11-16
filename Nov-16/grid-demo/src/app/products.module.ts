import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SortPipe } from './pipes/sort.pipe';
import { ProductsComponent } from './products-component/products.component';
import { ProductsRoutingModule } from './products-routing.module';

@NgModule({
  declarations: [ProductsComponent, SortPipe],

  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ProductsRoutingModule,
  ],

  exports: [ProductsComponent],
})
export class ProductsModule {}
