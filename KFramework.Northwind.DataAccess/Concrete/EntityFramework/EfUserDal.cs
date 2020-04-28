using KFramework.Core.DataAccess.EntityFramework;
using KFramework.Northwind.DataAccess.Abstract;
using KFramework.Northwind.Entities.ComplexTypes;
using KFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace KFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserRoleDto> GetUserRoles(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = (from ur in context.UserRoles
                             join r in context.Roles
                             on ur.RoleId equals r.Id
                             where ur.UserId == user.Id
                             select new UserRoleDto { RoleName = r.Name }).ToList();
                return result;
            }
        }
    }
}
