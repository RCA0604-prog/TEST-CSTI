import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Producto } from "../models/producto.model";
import { API_CONFIG } from "../config/config";

@Injectable({
    providedIn: 'root'
})

export class ProductoService{
    private apiUrl = `${API_CONFIG.BASE_URL}`;

    constructor(private http: HttpClient){}
    
    getAll(codigo?: string, nombre?: string): Observable<any> {
        let params: any = {};
        if (codigo) params.codigo = codigo;
        if (nombre) params.nombre = nombre;
        return this.http.get(`${this.apiUrl}/Producto/consultar`, { params });
    }

    create(producto: any): Observable<any> {
        return this.http.post(`${this.apiUrl}/Producto/insertar`, producto);
    }


}