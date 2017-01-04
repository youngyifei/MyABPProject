using Abp.Authorization;
using MyProject.Authorization.Roles;
using MyProject.MultiTenancy;
using MyProject.Users;

namespace MyProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
