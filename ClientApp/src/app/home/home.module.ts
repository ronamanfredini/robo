import { NgModule } from '@angular/core';
import { HomeComponent } from './home.component';
import { BracoModule } from '../braco/braco.module';
import { StateChanger } from '../../services/stateChanger';
import { CommonModule } from '@angular/common';
import { CabecaModule } from '../cabeca/cabeca.module';
@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    BracoModule,
    CabecaModule,
    CommonModule
  ],
  exports: [
  ],
  providers: [
    StateChanger
  ]
})
export class HomeModule { }
