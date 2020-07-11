import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Users } from '../models/Users';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  private usuariosUrl = `${environment.urlApi}api/usuarios`;
  constructor(private _httpClient: HttpClient) { }

  IniciarSesion(user: Users) {
    const url = `${this.usuariosUrl}/login`;
    return this._httpClient.post<boolean>(url, user);
  }
}
