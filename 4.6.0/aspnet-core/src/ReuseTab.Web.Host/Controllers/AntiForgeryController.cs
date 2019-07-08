using Microsoft.AspNetCore.Antiforgery;
using ReuseTab.Controllers;

namespace ReuseTab.Web.Host.Controllers
{
    public class AntiForgeryController : ReuseTabControllerBase
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
