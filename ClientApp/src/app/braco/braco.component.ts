import { Component, Input } from "@angular/core";
import { Braco } from "../../models/braco";
@Component({
  selector: 'braco',
  templateUrl: './braco.component.html'
})
export class BracoComponent {
  @Input('braco') braco: Braco;
}
