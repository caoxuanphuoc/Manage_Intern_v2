using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Manage_Intern_Version_2.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Common
{
    public class LookupAppService : Manage_Intern_Version_2AppServiceBase, ILookupAppService
    {
        private readonly IRepository<User> _userRepository;

        public LookupAppService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<ListResultDto<ComboboxItemDto>> GetUserComboboxItems()
        {
            var people = await _userRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                people.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.FullName)).ToList()
            );
        }
    }
}
