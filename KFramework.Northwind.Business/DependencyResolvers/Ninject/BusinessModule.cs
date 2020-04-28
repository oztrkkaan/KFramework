using KFramework.Core.DataAccess;
using KFramework.Core.DataAccess.EntityFramework;
using KFramework.Core.DataAccess.NHibernate;
using KFramework.Northwind.Business.Abstract;
using KFramework.Northwind.Business.Concrete.Managers;
using KFramework.Northwind.DataAccess.Abstract;
using KFramework.Northwind.DataAccess.Concrete.EntityFramework;
using KFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using KFramework.Northwind.Entities.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService, ProductManager>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
