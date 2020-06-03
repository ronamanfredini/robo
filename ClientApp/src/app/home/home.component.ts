import { Component } from '@angular/core';
import { Robo } from '../../models/robo';
import { Observable } from 'rxjs';
import { StateChanger } from '../../services/stateChanger';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public robo$: Observable<Robo>;

  constructor(stateChanger: StateChanger) {
    this.robo$ = stateChanger.getListenner();
    this.robo$.subscribe(console.log)
  }
}
