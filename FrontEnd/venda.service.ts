import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class VendaService {
    private apiUrl = 'http://localhost:5000/api/vendas';

    constructor(private http: HttpClient) { }

    realizarVenda(venda: any): Observable<any> {
        return this.http.post<any>(this.apiUrl, venda);
    }

    // Implementar outros métodos para consumir a API de vendas
}