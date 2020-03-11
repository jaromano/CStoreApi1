using Abp.Authorization;
using CStoreApi.Authorization.Roles;
using CStoreApi.Authorization.Users;

namespace CStoreApi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
