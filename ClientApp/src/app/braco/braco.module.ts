import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BracoComponent } from './braco.component';
import { ComponenteModule } from '../componente/componente.module';
import { CommonModule } from '@angular/common';
@NgModule({
  declarations: [
    BracoComponent
  ],
  imports: [
    ComponenteModule,
    CommonModule
  ],
  exports: [
    BracoComponent
  ]
})
export class BracoModule { }
