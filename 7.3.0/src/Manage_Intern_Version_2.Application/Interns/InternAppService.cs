using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Manage_Intern_Version_2.Interns.Dtos;
using Manage_Intern_Version_2.Users;
using Manage_Intern_Version_2.Users.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Interns
{
    public class InternAppService : Manage_Intern_Version_2AppServiceBase, IInterAppService
    {
        private readonly IRepository<Intern> _internRepository;
        InternAppService(IRepository<Intern> internRepository)
        {
            _internRepository = internRepository;
        }

        public async System.Threading.Tasks.Task Create(CreateFromUserTable createFromUserTable)
        {
            var intern = ObjectMapper.Map<Intern>(createFromUserTable);
            await _internRepository.InsertAsync(intern);
        }
    }
}
