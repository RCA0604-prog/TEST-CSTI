import { DIALOG_DATA, DialogRef } from '@angular/cdk/dialog';
import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ProductoService } from '../../services/producto.service';

@Component({
  selector: 'app-producto-modal',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './producto-modal.component.html',
  styleUrl: './producto-modal.component.css'
})

export class ProductoModalComponent {

  producto = {
    codigo: '',
    nombre: '',
    descripcion: '',
    precio: 0
  }

  loading = false;
  error = '';

  constructor( private dialogRef: DialogRef<ProductoModalComponent>,
    private productoService: ProductoService){}

  guardar(): void {
        if (!this.validarFormulario()) {
            return;
        }

        this.loading = true;
        this.error = '';

        this.productoService.create(this.producto).subscribe({
            next: (response) => {
                if (response.success) {
                    this.dialogRef.close();
                } else {
                    this.error = response.message || 'Error al guardar producto';
                }
                this.loading = false;
            },
            error: (err) => {
                this.error = 'Error de conexión con el servidor';
                this.loading = false;
                console.error(err);
            }
        });
    }

    validarFormulario(): boolean {
        if (!this.producto.codigo.trim()) {
            this.error = 'El código es requerido';
            return false;
        }
        if (!this.producto.nombre.trim()) {
            this.error = 'El nombre es requerido';
            return false;
        }
        if (this.producto.precio <= 0) {
            this.error = 'El precio debe ser mayor a 0';
            return false;
        }
        return true;
    }

    cerrar(): void {
        this.dialogRef.close();
    }


}
