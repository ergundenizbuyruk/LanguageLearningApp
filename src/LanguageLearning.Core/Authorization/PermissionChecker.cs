using Abp.Authorization;
using LanguageLearning.Authorization.Roles;
using LanguageLearning.Authorization.Users;

namespace LanguageLearning.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
