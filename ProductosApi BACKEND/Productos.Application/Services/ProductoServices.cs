using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using TestProducto.Application.Dtos;
using TestProducto.Application.Interfaces;
using TestProducto.Domain;
using TestProducto.Domain.Entities;
using TestProducto.Domain.Interfaces;
using TestProducto.Shared.ApiResponses;
using TestProductos.Application.Dtos;

namespace Productos.Application.Services
{
    public class ProductoServices : IProductoServices
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;

        public ProductoServices(IProductoRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponseGeneric<List<ProductoResponseDto>>> GetAllAsync(string? codigo, string? nombre)
        {
            var response = new BaseResponseGeneric<List<ProductoResponseDto>>();
            try
            {
                
                var productosQuery = await _productoRepository.GetAllProductsAsync();

                if (!string.IsNullOrEmpty(codigo))
                {
                    productosQuery = productosQuery.Where(p => p.Codigo.Contains(codigo));
                }

                if (!string.IsNullOrEmpty(nombre))
                {
                    productosQuery = productosQuery.Where(p => p.Nombre.Contains(nombre));
                }

                var productos = productosQuery.ToList();

                response = new BaseResponseGeneric<List<ProductoResponseDto>>()
                {
                    Success = true,
                    Message = productos.Any() ? "Productos obtenidos exitosamente" : "No se encontraron productos",
                    Data = _mapper.Map<List<ProductoResponseDto>>(productos)
                };
            }
            catch (Exception ex)
            {
                response = new BaseResponseGeneric<List<ProductoResponseDto>>()
                {
                    Success = false,
                    Message = $"Ocurrio un error al obtener los productos: {ex.Message}",
                    Data = null
                };
            }

            return response;
        }

        public async Task<BaseResponse> AddAsync(ProductoRequestDto request)
        {
            var response = new BaseResponse();

            try
            {
                var encontrado = _productoRepository.GetAllProductsAsync().Result.Any(x => x.Codigo == request.Codigo);

                if (encontrado)
                {
                    response = new BaseResponse()
                    {
                        Success = false,
                        Message = "Ya existe un producto con ese código"
                    };
                }


                var producto = _mapper.Map<Producto>(request);

                await _productoRepository.AddProductAsync(producto);

                response = new BaseResponse()
                {
                    Success = true,
                    Message = "Se creo correctamente el producto"
                };
            }
            catch (Exception ex)
            {
                response = new BaseResponse()
                {
                    Success = false,
                    Message = "Ocurrio un error al momento de crear el producto."
                };
            }

            return response;
        }

    }
}
