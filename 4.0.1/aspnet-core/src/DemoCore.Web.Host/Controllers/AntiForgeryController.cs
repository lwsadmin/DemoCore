using Microsoft.AspNetCore.Antiforgery;
using DemoCore.Controllers;

namespace DemoCore.Web.Host.Controllers
{
    public class AntiForgeryController : DemoCoreControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
