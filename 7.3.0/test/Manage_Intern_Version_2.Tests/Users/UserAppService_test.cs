using Manage_Intern_Version_2.Users;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Abp.Runtime.Validation;

namespace Manage_Intern_Version_2.Tests.Users
{
    public class UserAppService_test: Manage_Intern_Version_2TestBase
    {
        private readonly IUserAppService _userAppService;
      
        public UserAppService_test()
        {
            _userAppService = Resolve<IUserAppService>();
        }
        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Tasks()
        {
            //Act
            var output = await _userAppService.GetAll();

            //Assert
            output.Items.Count.ShouldBe(2);
        }
    }
}
