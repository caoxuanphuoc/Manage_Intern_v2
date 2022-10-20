using Manage_Intern_Version_2.Users.Dtos;
using System.Collections.Generic;

namespace Manage_Intern_Version_2.Web.Models.User
{
    public class UserViewModel
    {
        public IReadOnlyList<UserListDto> Users { get; }
        public UserViewModel (IReadOnlyList<UserListDto> users)
        {
            Users = users;
        }

    }
}
