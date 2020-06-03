import { Component, Input } from "@angular/core";
import { Componente } from "../../models/componente";
import { StateChanger } from "src/services/stateChanger";
import { Movimento } from "src/utils/movimento";

@Component({
  selector: 'componente',
  templateUrl: './componente.component.html'
})
export class ComponenteComponent {
  constructor(private stateChanger: StateChanger) {}
  @Input('nome') nome: string;
  @Input('componente') componente: Componente = new Componente('', '', '');
  @Input('noButtons') noButtons: boolean;

  public alterarEstado(movimentoDirecao: number, tipoMovimento: number): void {
    this.stateChanger.componentChanged(new Movimento(this.componente.id, movimentoDirecao, tipoMovimento));
  }
}
