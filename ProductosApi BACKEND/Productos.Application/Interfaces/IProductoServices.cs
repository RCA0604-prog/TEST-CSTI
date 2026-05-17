using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProducto.Application.Dtos;
using TestProducto.Domain;
using TestProducto.Shared.ApiResponses;
using TestProductos.Application.Dtos;

namespace TestProducto.Application.Interfaces
{
    public interface IProductoServices
    {
        Task<BaseResponseGeneric<List<ProductoResponseDto>>> GetAllAsync(string? codigo, string? nombre);
        Task<BaseResponse> AddAsync(ProductoRequestDto request);
    }
}
