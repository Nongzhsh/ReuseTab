using Abp.Authorization;
using ReuseTab.Authorization.Roles;
using ReuseTab.Authorization.Users;

namespace ReuseTab.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
