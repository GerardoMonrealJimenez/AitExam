import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Products } from '../models/Products';

@Injectable({
  providedIn: 'root'
})
export class ProductosService {
  private usuariosUrl = `${environment.urlApi}api/productos`;
  constructor(private _httpClient: HttpClient) { }

  ListaProductos() {
    return this._httpClient.get<Products[]>(this.usuariosUrl);
  }
}
