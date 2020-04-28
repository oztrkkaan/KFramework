using KFramework.Northwind.Business.Abstract;
using KFramework.Northwind.DataAccess.Abstract;
using KFramework.Northwind.Entities.ComplexTypes;
using KFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace KFramework.Northwind.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetbyUsernameAndPassword(string username, string password)
        {
            return _userDal.Get(x => x.Username == username && x.Password == password);
        }

        public List<UserRoleDto> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
