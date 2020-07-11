import { Component, OnInit } from '@angular/core';
import { Products } from 'src/app/models/Products';
import { ProductosService } from '../productos.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-lista-productos',
  templateUrl: './lista-productos.component.html',
  styleUrls: ['./lista-productos.component.css']
})
export class ListaProductosComponent implements OnInit {
  productos: Observable<Products[]>;
  constructor(private _productsService: ProductosService) { }

  ngOnInit() {
    this.obtenerProductos();
  }

  obtenerProductos() {
    this.productos = this._productsService.ListaProductos();
  }

}
