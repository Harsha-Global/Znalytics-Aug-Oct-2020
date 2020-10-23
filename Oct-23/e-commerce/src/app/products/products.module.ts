import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsComponent } from './products.component';
import { NewProductComponent } from '../new-product/new-product.component';
import { EditProductComponent } from '../edit-product/edit-product.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ProductsService } from '../products.service';
import { ThousandsConverterPipe } from '../thousands-converter.pipe';
import { ContactComponent } from '../contact/contact.component';

@NgModule({
  declarations: [
    ProductsComponent,
    NewProductComponent,
    EditProductComponent,
    ThousandsConverterPipe,
    ContactComponent
  ],
  
  exports: [
    ThousandsConverterPipe
  ],

  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule
  ],

  providers: [ ProductsService ]
})
export class ProductsModule { }
