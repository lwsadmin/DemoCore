using Abp.AspNetCore.Mvc.ViewComponents;

namespace DemoCore.Web.Views
{
    public abstract class DemoCoreViewComponent : AbpViewComponent
    {
        protected DemoCoreViewComponent()
        {
            LocalizationSourceName = DemoCoreConsts.LocalizationSourceName;
        }
    }
}
