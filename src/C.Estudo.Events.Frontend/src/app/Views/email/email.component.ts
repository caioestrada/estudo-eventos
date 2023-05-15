import { Component, OnInit } from '@angular/core';
import { Email } from 'src/app/models/Email.model';
import { EmailService } from 'src/app/services/email.service';

@Component({
  selector: 'app-email',
  templateUrl: './email.component.html',
  styleUrls: ['./email.component.css']
})
export class EmailComponent implements OnInit {
  emailItens: Array<Email>;

  constructor(private emailService: EmailService) { }

  ngOnInit() {
    this.obterTodos();
  }

  public obterTodos() {
    this.emailService.obterTodos().subscribe(
      retornoEmailService => { this.emailItens = retornoEmailService; },
      () => { alert('Serviço de email esta offline!'); }
    );
  }
}
