using FluentValidation;
using KFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFramework.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 20);
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(p => p.CategoryId == 1);
        }
    }
}
