using KFramework.Core.DataAccess.EntityFramework;
using KFramework.Northwind.DataAccess.Abstract;
using System.Collections.Generic;
using KFramework.Northwind.Entities.Concrete;
using KFramework.Northwind.Entities.ComplexTypes;
using System.Linq;

namespace KFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
