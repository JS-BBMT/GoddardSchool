using Microsoft.AspNetCore.Mvc;
using FranchiseePortal.Web.Controllers;

namespace FranchiseePortal.Web.Public.Controllers
{
    public class HomeController : FranchiseePortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}