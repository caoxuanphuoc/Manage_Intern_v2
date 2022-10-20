using Manage_Intern_Version_2.Users;
using Manage_Intern_Version_2.Web.Models.User;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Web.Controllers
{
    public class UsersController: Manage_Intern_Version_2ControllerBase
    {
        private readonly IUserAppService _userAppService;
        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetAll();
            var model = new UserViewModel(output.Items);
            return View(model);
        }
    }
}
