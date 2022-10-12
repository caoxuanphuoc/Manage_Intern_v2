using Abp.AspNetCore.Mvc.Controllers;

namespace Manage_Intern_Version_2.Web.Controllers
{
    public abstract class Manage_Intern_Version_2ControllerBase: AbpController
    {
        protected Manage_Intern_Version_2ControllerBase()
        {
            LocalizationSourceName = Manage_Intern_Version_2Consts.LocalizationSourceName;
        }
    }
}