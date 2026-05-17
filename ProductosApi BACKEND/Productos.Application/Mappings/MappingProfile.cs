using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TestProducto.Application.Dtos;
using TestProducto.Domain.Entities;
using TestProductos.Application.Dtos;

namespace TestProductos.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<Producto, ProductoResponseDto>();
            CreateMap<ProductoRequestDto, Producto>().ForMember(x => x.Id, op => op.Ignore());
        }
    }
}
