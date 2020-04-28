using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security;

namespace KFramework.Core.Aspects.PostSharp.AuthorizationAspects
{
    [Serializable]
    public class SecuredOperation : OnMethodBoundaryAspect
    {
        public string Roles { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles = Roles.Split(',');
            bool isAuthorize = false;
            foreach (var role in roles)
            {
                if (Thread.CurrentPrincipal.IsInRole(role))
                {
                    isAuthorize = true;
                }
            }
            if (!isAuthorize)
            {
                throw new SecurityException("You are not authorized");
            }
        }
    }
}
