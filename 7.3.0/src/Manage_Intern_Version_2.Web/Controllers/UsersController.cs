using Abp.Application.Services.Dto;
using Manage_Intern_Version_2.Common;
using Manage_Intern_Version_2.Users;
using Manage_Intern_Version_2.Web.Models.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Web.Controllers
{
    public class UsersController: Manage_Intern_Version_2ControllerBase
    {
        private readonly IUserAppService _userAppService;
        private readonly ILookupAppService _lookupAppService;
        public UsersController(IUserAppService userAppService, ILookupAppService lookupAppService)
        {
            _userAppService = userAppService;
            _lookupAppService = lookupAppService;
        }
        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetAll();
            var model = new UserViewModel(output.Items);
            return View(model);
        }
        public async Task<ActionResult> Create()
        {
            var peopleSelectListItems = (await _lookupAppService.GetUserComboboxItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            peopleSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("Unassigned"), Selected = true });

            return View();
            //new CreateUserViewModel(peopleSelectListItems)
        }
    }
}
