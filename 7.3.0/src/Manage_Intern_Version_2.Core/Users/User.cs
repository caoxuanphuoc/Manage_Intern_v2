using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Intern_Version_2.Interns;
using Manage_Intern_Version_2.Mentors;

namespace Manage_Intern_Version_2.Users
{
    [Table("User")]
    public class User : Entity
    {
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string PassWord { get; set; }
        public int? Role { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        public string Gmail { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        public User(
            string userName, string passWord, string fullName, string phoneNumber, string gmail)
        {
            UserName = userName;
            PassWord = passWord;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Gmail = gmail;
        }
    }
}
