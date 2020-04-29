using AutoMapper;
using KFramework.Northwind.Entities.Concrete;
using KFramework.Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFramework.Northwind.Business.Mappings.AutoMapper
{
   public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, Product>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }
      
    }
}
