using KFramework.Core.CrossCuttingConcerns.FluentValidation;
using KFramework.Northwind.Business.Abstract;
using KFramework.Northwind.Business.ValidationRules.FluentValidation;
using KFramework.Northwind.DataAccess.Abstract;
using KFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using KFramework.Core.Aspects.PostSharp;

namespace KFramework.Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        
        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
