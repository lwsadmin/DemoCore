using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using DemoCore.Controllers;

namespace DemoCore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DemoCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
