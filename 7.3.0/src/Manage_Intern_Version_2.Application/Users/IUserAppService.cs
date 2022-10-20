using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Manage_Intern_Version_2.Users.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task<ListResultDto<UserListDto>> GetAll();
    }
}
