using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Intern_Version_2.Users.Dtos
{
    [AutoMapTo(typeof(User))]
    public class CreateUserInput 
    {
        [StringLength(50)]
        [Required]   
        public string UserName { get; set; }
        [StringLength(50)]
        public string PassWord { get; set; }
        [StringLength(50)]
        public  string ConfirmPassWord { get; set; }
        public int Role { get; set; }
     
    }
}
