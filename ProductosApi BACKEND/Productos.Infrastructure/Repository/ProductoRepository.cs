using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProducto.Application.Dtos;
using TestProducto.Domain.Entities;
using TestProducto.Domain.Interfaces;
using TestProducto.Shared.ApiResponses;
using TestProductos.Application.Dtos;
using TestProductos.Infrastructure.Data;

namespace TestProducto.Infrastructure.Repository
{
    public class ProductoRepository: IProductoRepository
    {
        private readonly AppDbContext _context;
        
        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Producto>> GetAllProductsAsync()
        {
            return _context.Productos.AsQueryable();
        }

        public async Task AddProductAsync(Producto producto)
        {
            producto.FechaCreacion = DateTime.Now;

            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
        }


    }
}
