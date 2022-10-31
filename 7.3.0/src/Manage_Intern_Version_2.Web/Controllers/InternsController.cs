using Manage_Intern_Version_2.Interns;
using Manage_Intern_Version_2.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Web.Controllers
{
    public class InternsController : Manage_Intern_Version_2ControllerBase
    {
        private readonly IInterAppService _internAppService;
        public InternsController( IInterAppService interAppService)
        {
           _internAppService = interAppService;
        } 
    }
}
