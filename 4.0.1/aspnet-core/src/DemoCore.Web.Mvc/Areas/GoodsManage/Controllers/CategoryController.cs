using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using DemoCore.Controllers;
using DemoCore.GoodsManage.Category.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.Web.Mvc.Areas.GoodsManage.Controllers
{
    [Area("GoodsManage")]
    [AbpMvcAuthorize]
    public class CategoryController : DemoCoreControllerBase
    {
        private readonly ICategoryAppService _catServices;
        public CategoryController(ICategoryAppService catServices)
        {
            _catServices = catServices;
        }
        public async Task<IActionResult> List()
        {
           
            var dtos = await _catServices.GetAllListAsync();
            return View(dtos);
        }
    }
}