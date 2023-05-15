import { Component, OnInit } from '@angular/core';
import { Orbcore } from 'src/app/models/orbcore.model';
import { OrbcoreService } from 'src/app/services/orbcore.service';

@Component({
  selector: 'app-orbcore',
  templateUrl: './orbcore.component.html',
  styleUrls: ['./orbcore.component.css']
})
export class OrbcoreComponent implements OnInit {
  orbcoreItens: Orbcore[];
  public orbcoreAdicionar: Orbcore;

  constructor(private orbcoreService: OrbcoreService) {}

  ngOnInit() {
    this.orbcoreAdicionar = new Orbcore();
    this.obterTodos();
  }

  public obterTodos() {
    this.orbcoreService.obterTodos().subscribe(
      retornoOrbCoreService => { this.orbcoreItens = retornoOrbCoreService ? retornoOrbCoreService : []; },
      () => { alert('Serviço do orbcore esta offline!'); }
    );
  }

  public adicionarObjeto() {
    this.orbcoreAdicionar.converterMetodos();
    this.orbcoreService.adicionar(this.orbcoreAdicionar).subscribe(
      retornoOrbCoreService => { this.adicionar(retornoOrbCoreService); },
      () => { alert('Serviço do orbcore esta offline!'); }
    );
  }

  private adicionar(orbcore: Orbcore) {
    this.orbcoreItens.push(orbcore);
  }
}
