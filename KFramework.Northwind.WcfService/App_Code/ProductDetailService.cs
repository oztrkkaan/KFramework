using KFramework.Northwind.Business.Abstract;
using KFramework.Northwind.Business.DependencyResolvers.Ninject;
using KFramework.Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService:IProductDetailService
{
    IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public ProductDetailService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<ProductDto> GetAll()
    {
        return _productService.GetAll();
    }
}