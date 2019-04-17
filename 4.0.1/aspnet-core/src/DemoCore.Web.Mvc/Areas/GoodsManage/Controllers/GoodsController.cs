using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using DemoCore.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.Web.Mvc.Areas.GoodsManage.Controllers
{
    [Area("GoodsManage")]
    [AbpMvcAuthorize]
    public class GoodsController : DemoCoreControllerBase
    {
        public IActionResult List()
        {
            return View();
        }
    }
}