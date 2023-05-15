export class Orbcore {
  objeto: string;
  responsavel: string;
  metodosView: string;
  metodos: string[];

  constructor() {
    this.objeto = '';
    this.responsavel = '';
    this.metodosView = '';
    this.metodos = [];
  }

  converterMetodos() {
    this.metodos = this.metodosView.split(', ');
  }
}
