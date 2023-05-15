import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Email } from '../models/Email.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmailService {

  constructor(private httpClient: HttpClient) { }

  obterTodos(): Observable<Array<Email>> {
    return this.httpClient.get<Array<Email>>('http://localhost:9997/api/Email');
  }
}
