import { Component } from "@angular/core"

@Component({
  selector: "atleta",
  template: "",

})
export class AtletaComponent {
  public nome: string;
  public hastag: string;

  public obterNome() {
    return this.nome;
  }


}
