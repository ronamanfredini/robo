import { Component, Input } from "@angular/core";
import { Cabeca } from "src/models/cabeca";
import { StateChanger } from "../../services/stateChanger";
import { Movimento } from "../../utils/movimento";
@Component({
  selector: 'cabeca',
  templateUrl: './cabeca.component.html'
})
export class CabecaComponent {
  @Input('cabeca') cabeca: Cabeca;

  constructor(private stateChanger: StateChanger) {
  }

  public alterarInclinacao(movimentoDirecao: number): void {
    this.stateChanger.componentChanged(new Movimento(this.cabeca.id, movimentoDirecao, 1));
  }
}
