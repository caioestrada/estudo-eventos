import { Component, OnInit } from '@angular/core';
import { Autsis } from 'src/app/models/autsis.model';
import { AutsisService } from 'src/app/services/autsis.service';

@Component({
  selector: 'app-autsis',
  templateUrl: './autsis.component.html',
  styleUrls: ['./autsis.component.css']
})
export class AutsisComponent implements OnInit {
  autsisItens: Array<Autsis>;

  constructor(private autsisService: AutsisService) {}

  ngOnInit() {
    this.obterTodos();
  }

  public obterTodos() {
    this.autsisService.obterTodos().subscribe(
      retornoAutsisService => { this.autsisItens = retornoAutsisService; },
      () => { alert('Serviço do autsis esta offline!'); }
    );
  }
}
