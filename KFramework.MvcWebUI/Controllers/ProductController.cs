using KFramework.MvcWebUI.Models;
using KFramework.Northwind.Business.Abstract;
using KFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KFramework.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }
        public string Add()
        {
            _productService.Add(new Product { 
            CategoryId=1,
            ProductName ="GSM",
            QuantityPerUnit="1",
            UnitPrice=12
            });
            return "Added";
        }
    }
}