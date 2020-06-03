import { Component } from '@angular/core';
import { RoboService } from '../services/robo.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'R.O.B.O.';

  constructor(private roboService: RoboService) { }
}
