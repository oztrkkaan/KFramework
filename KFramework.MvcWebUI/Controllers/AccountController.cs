using KFramework.Core.CrossCuttingConcerns.Security.Web;
using KFramework.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KFramework.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Account
        public string Login(string username, string password)
        {
            var user = _userService.GetbyUsernameAndPassword(username, password);

            if (user != null)
            {
                var userRoles = _userService.GetUserRoles(user).Select(m => m.RoleName).ToArray();
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(), user.Username,
                    user.Email,
                    DateTime.Now.AddDays(15),
                   userRoles,
                    false,
                    user.FirstName,
                     user.LastName);
                return "User is authenticated!";
            }
            return "null";
        }
    }
}