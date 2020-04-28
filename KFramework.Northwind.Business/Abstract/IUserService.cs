using KFramework.Northwind.Entities.ComplexTypes;
using KFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace KFramework.Northwind.Business.Abstract
{
    public  interface IUserService
    {
        User GetbyUsernameAndPassword(string username, string password);
      List<UserRoleDto> GetUserRoles(User user);

    }
}
