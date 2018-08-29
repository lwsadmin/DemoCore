using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AutoMapper;
using DemoCore.Sessions;
using DemoCore.Web.Views.Shared.Components.TenantChange;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.Web.Views.Shared.Components.Test
{
    public class TestViewComponent : DemoCoreViewComponent
    {
        private readonly ISessionAppService _sessionAppService;

        public TestViewComponent(ISessionAppService sessionAppService)
        {
            _sessionAppService = sessionAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionAppService.GetCurrentLoginInformations();
            var model = loginInfo.MapTo<TenantChangeViewModel>();
            return View(model);
        }
    }
}
