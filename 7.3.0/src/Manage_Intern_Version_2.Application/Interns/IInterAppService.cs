using Abp.Application.Services;
using Manage_Intern_Version_2.Interns.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Interns
{
    public interface IInterAppService : IApplicationService
    {
        System.Threading.Tasks.Task Create(CreateFromUserTable createFromUserTable);
    }
}
