using KFramework.Core.DataAccess.EntityFramework;
using KFramework.Northwind.DataAccess.Abstract;
using KFramework.Northwind.DataAccess.Concrete.EntityFramework;
using KFramework.Northwind.Entities.Concrete;

namespace KFramework.Northwind.DataAccess.Concrete
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
