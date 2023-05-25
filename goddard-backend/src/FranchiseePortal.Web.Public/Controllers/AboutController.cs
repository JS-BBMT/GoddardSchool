using Microsoft.AspNetCore.Mvc;
using FranchiseePortal.Web.Controllers;

namespace FranchiseePortal.Web.Public.Controllers
{
    public class AboutController : FranchiseePortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}