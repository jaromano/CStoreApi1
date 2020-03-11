using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CStoreApi.Controllers
{
    public abstract class CStoreApiControllerBase: AbpController
    {
        protected CStoreApiControllerBase()
        {
            LocalizationSourceName = CStoreApiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
