using KFramework.Northwind.Business.Abstract;
using KFramework.Northwind.Entities.Concrete;
using KFramework.Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KFramework.Northwind.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public List<ProductDto> Get()
        {
            return _productService.GetAll();
        }
    }
}
