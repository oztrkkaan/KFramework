using KFramework.Core.DataAccess;
using KFramework.Northwind.Entities.ComplexTypes;
using KFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace KFramework.Northwind.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<UserRoleDto> GetUserRoles(User user);
    }
}
