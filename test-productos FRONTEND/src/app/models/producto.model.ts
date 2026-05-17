export interface Producto{
    id:number;
    nombre: string;
    codigo: string;
    descripcion?: string;
    precio: number;
    fechaCreacion: Date;
}