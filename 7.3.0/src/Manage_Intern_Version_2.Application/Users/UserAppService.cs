using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Manage_Intern_Version_2.Interns;
using Manage_Intern_Version_2.Mentors;
using Manage_Intern_Version_2.Users.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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
        public async System.Threading.Tasks.Task Create(CreateUserInput input) {
         
            System.Diagnostics.Debug.WriteLine("hi anh Phuoc tui tim thay input ne: " + input.UserName + ' '
                    + input.PassWord + ' ' +  input.Role);
            var input2 = new 
            {
                UserName= input.UserName,
                PassWord= input.PassWord,
                Role= input.Role
            };
            var user = ObjectMapper.Map<User>(input);
            await _userRepository.InsertAsync(user);
            System.Diagnostics.Debug.WriteLine(user);
     /*       if (input.PassWord == input.ConfirmPassWord){// fixx
                await _userRepository.InsertAsync(user);
                if (input.Role == 1)
                {
                    var mentor = new Mentor(user.Id);
                    await _mentorRepository.InsertAsync(mentor);
                }else if (input.Role ==2)
                {
                    var intern  = new Intern(user.Id);
                    await _internRepository.InsertAsync(intern);
                } 
            }*/
            
        }
    }
}
