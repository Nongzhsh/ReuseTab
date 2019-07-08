using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ReuseTab.Controllers
{
    public abstract class ReuseTabControllerBase: AbpController
    {
        protected ReuseTabControllerBase()
        {
            LocalizationSourceName = ReuseTabConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
