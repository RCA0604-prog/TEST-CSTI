using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProducto.Application.Dtos
{
    public class ProductoResponseDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}