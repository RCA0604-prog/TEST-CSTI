using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProductos.Application.Dtos
{
    public class ProductoRequestDto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
