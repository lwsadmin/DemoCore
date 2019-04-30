using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Notifications;
using DemoCore.Controllers;
using DemoCore.GoodsManage.Category.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.Web.Mvc.Areas.GoodsManage.Controllers
{
    [Area("GoodsManage")]
    [AbpMvcAuthorize]
    public class GoodsController : DemoCoreControllerBase
    {  

        //private
        private readonly IRealTimeNotifier _not;
        private readonly ICategoryAppService _catServices;
        public GoodsController(IRealTimeNotifier not, ICategoryAppService catServices)
        {
            _not = not;
            _catServices = catServices;
        }
        public IActionResult List()
        {
            /////----------------------------
            ///

            // notArray[0] = new UserNotification() { Id = Guid.NewGuid(), TenantId = 1, UserNotificationState.Unread }


            return View();
        }

        public void Send()
        {

        }


        public async Task<FileResult> Test()
        {
            MemoryStream ms = await _catServices.Export();
            return File(ms.ToArray(), "application/vnd.ms-excel", "ss.txt");
        }
    }
}