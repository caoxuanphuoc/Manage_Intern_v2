using Manage_Intern_Version_2.Users;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Abp.Runtime.Validation;
using Manage_Intern_Version_2.Users.Dtos;
using Manage_Intern_Version_2.Interns;
using Manage_Intern_Version_2.Interns.Dtos;

namespace Manage_Intern_Version_2.Tests.Users
{
    public class UserAppService_test: Manage_Intern_Version_2TestBase
    {
        private readonly IUserAppService _userAppService;
        private readonly IInterAppService _internAppService;

        public UserAppService_test()
        {
            _userAppService = Resolve<IUserAppService>();
            _internAppService = Resolve<IInterAppService>();
        }
        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Tasks()
        {
            //Act
            var output = await _userAppService.GetAll();

            //Assert
            output.Items.Count.ShouldBe(2);
        }
        [Fact]
        public async System.Threading.Tasks.Task Should_Create_New_User()
        {
            await _userAppService.Create(new CreateUserInput
            {
                UserName = "xuanphuoc",
                PassWord = "123",
                ConfirmPassWord = "123",
                Role = 2

            });
            UsingDbContext(context =>
            {
                var user1 = context.Users.FirstOrDefault(t => t.Id == 4);
                user1.ShouldNotBeNull();
            });
        }
        [Fact]
        public async System.Threading.Tasks.Task Should_Create_New_Intern()
        {
            await _internAppService.Create(new CreateFromUserTable
            {
                UserId =2
            }) ;
            UsingDbContext(context =>
            {
                var user1 = context.Interns.FirstOrDefault(t => t.Id == 1);
                user1.ShouldNotBeNull();
            });
        }
    }
}
