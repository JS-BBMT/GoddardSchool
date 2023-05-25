using Microsoft.AspNetCore.Antiforgery;

namespace FranchiseePortal.Web.Controllers
{
    public class AntiForgeryController : FranchiseePortalControllerBase
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
