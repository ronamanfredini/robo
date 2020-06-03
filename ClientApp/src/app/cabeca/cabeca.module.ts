import { NgModule } from '@angular/core';
import { ComponenteModule } from '../componente/componente.module';
import { CommonModule } from '@angular/common';
import { CabecaComponent } from './cabeca.component';
@NgModule({
  declarations: [
    CabecaComponent
  ],
  imports: [
    ComponenteModule,
    CommonModule
  ],
  exports: [
    CabecaComponent
  ]
})
export class CabecaModule { }
