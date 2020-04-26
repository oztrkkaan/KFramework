using FluentValidation;
using KFramework.Northwind.Business.ValidationRules.FluentValidation;
using KFramework.Northwind.Entities.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFramework.Northwind.Business.DependencyResolvers.Ninject
{
  public  class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
    }
}
