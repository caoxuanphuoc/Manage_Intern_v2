using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Manage_Intern_Version_2.Users.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Users
{
    public class UserAppService : Manage_Intern_Version_2AppServiceBase , IUserAppService
    {
         private readonly IRepository<User> _userRepository;
        public UserAppService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ListResultDto<UserListDto>> GetAll()
        {
            var user = await _userRepository
                .GetAll()
                .ToListAsync();
            return new ListResultDto<UserListDto>(
                    ObjectMapper.Map<List<UserListDto>>(user)
                    );
           // throw new NotImplementedException();
        }
    }
}
