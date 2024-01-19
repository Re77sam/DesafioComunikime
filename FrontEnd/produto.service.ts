import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class ProdutoService {
    private apiUrl = 'http://localhost:5000/api/produtos';

    constructor(private http: HttpClient) { }

    getAllProdutos(): Observable<any[]> {
        return this.http.get<any[]>(this.apiUrl);
    }

    // Implementar métodos CRUD para consumir a API de produtos
}