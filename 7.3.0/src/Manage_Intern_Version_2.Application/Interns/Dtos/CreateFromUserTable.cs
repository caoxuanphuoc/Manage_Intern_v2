
using Abp.AutoMapper;
using Manage_Intern_Version_2.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Interns.Dtos
{
    [AutoMapTo(typeof(Intern))]
    public class CreateFromUserTable
    {
        [Required]
        public int UserId { get; set; }
    }
}
