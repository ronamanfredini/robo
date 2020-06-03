import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ComponenteComponent } from './componente.component';
import { CommonModule } from '@angular/common';
@NgModule({
  declarations: [
    ComponenteComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports: [
    ComponenteComponent
  ]
})
export class ComponenteModule { }
