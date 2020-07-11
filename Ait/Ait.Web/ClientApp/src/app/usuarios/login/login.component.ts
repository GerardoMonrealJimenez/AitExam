import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Users } from 'src/app/models/Users';
import { UsuarioService } from '../usuario.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  constructor(private _formBuilder: FormBuilder,
    private _usuarioService: UsuarioService,
    private _routes: Router) { }

  ngOnInit() {
    this.loginForm = this._formBuilder.group({
      Nombre: ['', [Validators.required]],
      Password: ['', [Validators.required]],
    });
  }

  Save() {
    if (this.loginForm.valid) {
      this._usuarioService.IniciarSesion(this.obtenerDatos()).subscribe(
        (result: boolean) => {
          if (result) {
            this._routes.navigate(['/productos']);
          }
        },
        err => {
          console.log('error del servidor');
        },
        () => { }
      );
    }
  }

  obtenerDatos(): Users {
    return {
      nombre: this.loginForm.get('Nombre').value,
      password: this.loginForm.get('Password').value,
      apellido: '',
      idUser: 0,
      activo: null
    };
  }

}
