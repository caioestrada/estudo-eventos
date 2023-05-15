import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Orbcore } from '../models/orbcore.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrbcoreService {

  constructor(private httpClient: HttpClient) { }

  obterTodos(): Observable<Array<Orbcore>> {
    return this.httpClient.get<Array<Orbcore>>('http://localhost:9999/api/Objeto');
  }

  adicionar(orbcore: Orbcore): Observable<Orbcore> {
    return this.httpClient.post<Orbcore>('http://localhost:9999/api/Objeto', orbcore);
  }
}
