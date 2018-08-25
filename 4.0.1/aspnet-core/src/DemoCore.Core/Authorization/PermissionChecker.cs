using Abp.Authorization;
using DemoCore.Authorization.Roles;
using DemoCore.Authorization.Users;

namespace DemoCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
