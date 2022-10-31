using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Intern_Version_2.Users;

namespace Manage_Intern_Version_2.Mentors
{
    [Table("Mentor")]
    public class Mentor : Entity
    {
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [MaxLength(50)]
        public string EmployeeCode { get; set; }
        [MaxLength(50)]
        public string DepartMent { get; set; }
        public Mentor(int id)
        {
            UserId = id;
        }
    }
}
