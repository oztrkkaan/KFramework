using System;
using FluentValidation;
using KFramework.Northwind.Business.Concrete.Managers;
using KFramework.Northwind.DataAccess.Abstract;
using KFramework.Northwind.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace KFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            productManager.Add(new Product());
        }
    }
}
