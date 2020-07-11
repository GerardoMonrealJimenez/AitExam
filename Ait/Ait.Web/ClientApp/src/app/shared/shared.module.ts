import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { FlexLayoutModule } from '@angular/flex-layout';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MaterialDesignModule } from '../material-design/material-design.module';

const routes: Routes = [];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forRoot(routes),
    FlexLayoutModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,
    MaterialDesignModule
  ],
  exports: [
    CommonModule,
    BrowserModule,
    FlexLayoutModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,
    MaterialDesignModule
  ]
})
export class SharedModule { }
