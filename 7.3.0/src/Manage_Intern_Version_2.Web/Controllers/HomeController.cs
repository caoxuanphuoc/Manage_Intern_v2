using Microsoft.AspNetCore.Mvc;

namespace Manage_Intern_Version_2.Web.Controllers
{
    public class HomeController : Manage_Intern_Version_2ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}