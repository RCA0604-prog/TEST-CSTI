import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Dialog, DialogModule } from '@angular/cdk/dialog';
import { ProductoService } from '../../services/producto.service';
import { Producto } from '../../models/producto.model';
import { ProductoModalComponent } from '../producto-modal/producto-modal.component';

@Component({
  selector: 'app-producto-list',
  standalone: true,
  imports: [CommonModule, FormsModule, DialogModule],
  templateUrl: './producto-list.component.html',
  styleUrl: './producto-list.component.css'
})


export class ProductoListComponent  implements OnInit{
  productos: Producto[] = [];
  fCodigo: string = '';
  fNombre: string = '';
  loading: boolean = false;

  constructor(private productoService: ProductoService, private dialog: Dialog){}

  ngOnInit(): void {
    this.cargarProductos();
  }

    cargarProductos(): void {
            this.loading = true;
            this.productoService.getAll(this.fCodigo, this.fNombre).subscribe({
                next: (response) => {
                    if (response.success) {
                        this.productos = response.data;
                    }
                    this.loading = false;
                },
                error: (error) => {
                    console.error('Error al cargar productos:', error);
                    this.loading = false;
                }
            });
    }

    filtrar(): void {
        this.cargarProductos();
    }

    limpiarFiltros(): void {
        this.fCodigo = '';
        this.fNombre = '';
        this.cargarProductos();
    }

    abrirFormulario(): void {
        const dialogRef = this.dialog.open(ProductoModalComponent, {
            width: '800px',
            disableClose: true
        });

        dialogRef.closed.subscribe(() => {
            this.cargarProductos();  // ← Siempre recarga, sin importar el resultado
        });
    }




}
