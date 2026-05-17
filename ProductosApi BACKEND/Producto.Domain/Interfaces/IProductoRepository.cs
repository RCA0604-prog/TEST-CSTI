using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProducto.Domain.Entities;

namespace TestProducto.Domain.Interfaces
{
    public interface IProductoRepository
    {
        Task<IQueryable<Producto>> GetAllProductsAsync();

        Task AddProductAsync(Producto producto);

    }
}