using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProducto.Application.Dtos;
using TestProducto.Application.Interfaces;
using TestProducto.Domain.Entities;
using TestProducto.Shared.ApiResponses;
using TestProductos.Application.Dtos;

namespace Productos.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private readonly IProductoServices _productoServices;

        public ProductoController(IProductoServices productoServices)
        {
            _productoServices = productoServices;
        }

        [HttpGet("consultar")]
        public async Task<IActionResult> GetAll([FromQuery] string? codigo, [FromQuery] string? nombre)
        {
            var responses = new BaseResponseGeneric<List<ProductoResponseDto>>();
            
            responses = await _productoServices.GetAllAsync(codigo, nombre);

            if (!responses.Success)
            {
                return BadRequest(responses);
            }

            return Ok(responses);
        }

        [HttpPost("insertar")]
        public async Task<IActionResult> Create([FromBody] ProductoRequestDto request)
        {
            var responses = new BaseResponse();

            responses = await _productoServices.AddAsync(request);

            if (!responses.Success)
            {
                return BadRequest(responses);
            }

            return Ok(responses);
        }


    }
}
