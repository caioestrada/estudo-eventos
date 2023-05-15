import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Autsis } from '../models/autsis.model';

@Injectable({
  providedIn: 'root'
})
export class AutsisService {

  constructor(private httpClient: HttpClient) { }

  obterTodos(): Observable<Array<Autsis>> {
    return this.httpClient.get<Array<Autsis>>('http://localhost:9998/api/Sistema');
  }
}
