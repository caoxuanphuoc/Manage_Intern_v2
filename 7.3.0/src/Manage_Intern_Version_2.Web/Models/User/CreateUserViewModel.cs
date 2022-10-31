using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Manage_Intern_Version_2.Web.Models.User
{
    public class CreateUserViewModel
    {
        public List<SelectListItem> User { get; set; }

        public CreateUserViewModel(List<SelectListItem> user)
        {
            User = user;
        }
    }
}
