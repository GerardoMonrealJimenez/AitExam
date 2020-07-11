import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductosRoutingModule } from './productos-routing.module';
import { ListaProductosComponent } from './lista-productos/lista-productos.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [ListaProductosComponent],
  imports: [
    SharedModule,
    ProductosRoutingModule
  ]
})
export class ProductosModule { }
