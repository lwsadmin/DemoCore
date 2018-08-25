﻿using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace DemoCore.Web.Views
{
    public abstract class DemoCoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected DemoCoreRazorPage()
        {
            LocalizationSourceName = DemoCoreConsts.LocalizationSourceName;
        }
    }
}
