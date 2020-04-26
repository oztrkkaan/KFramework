﻿using KFramework.Core.CrossCuttingConcerns.FluentValidation;
using KFramework.Northwind.Business.Abstract;
using KFramework.Northwind.Business.ValidationRules.FluentValidation;
using KFramework.Northwind.DataAccess.Abstract;
using KFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Transactions;
using KFramework.Core.Aspects.PostSharp.ValidationAspects;
using KFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using KFramework.Core.Aspects.PostSharp.CacheAspects;

namespace KFramework.Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;


        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Product> GetAll()
        {

            throw new NotImplementedException();
        }
        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }


        public void TransactionalOperation(Product product1, Product product2)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                _productDal.Add(product1);
                _productDal.Add(product2);
            }
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
