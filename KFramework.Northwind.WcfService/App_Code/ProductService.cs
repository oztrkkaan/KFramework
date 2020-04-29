using KFramework.Northwind.Business.Abstract;
using KFramework.Northwind.Business.DependencyResolvers.Ninject;
using KFramework.Northwind.Entities.Concrete;
using KFramework.Northwind.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductService
/// </summary>
public class ProductService:IProductService
{

    public ProductService()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public Product Add(Product product)
    {
        return _productService.Add(product);
    }

    public List<ProductDto> GetAll()
    {
        return _productService.GetAll();
    }

    public Product GetById(int id)
    {
        return _productService.GetById(id);
    }

    public void TransactionalOperation(Product product1, Product product2)
    {
        _productService.TransactionalOperation(product1, product2);
    }

    public Product Update(Product product)
    {
        return _productService.Update(product);
    }
}