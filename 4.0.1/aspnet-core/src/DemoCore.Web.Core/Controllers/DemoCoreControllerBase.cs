using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DemoCore.Controllers
{
    public abstract class DemoCoreControllerBase: AbpController
    {
        protected DemoCoreControllerBase()
        {
            LocalizationSourceName = DemoCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
