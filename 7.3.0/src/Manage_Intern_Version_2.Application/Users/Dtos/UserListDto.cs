using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Users.Dtos
{
    [AutoMapFrom(typeof(User))]
    public class UserListDto: EntityDto
    {
        public String UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public String Gmail { get; set; }
        public String PhoneNumber { get; set; }
    }
}
