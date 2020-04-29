using KFramework.Northwind.Entities.Concrete;
using KFramework.Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KFramework.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<ProductDto> Products { get; set; }

    }
}