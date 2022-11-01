using Abp.Domain.Entities;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Intern_Version_2.Users;
using System.Diagnostics.CodeAnalysis;

namespace Manage_Intern_Version_2.Interns
{
    [Table("Intern")]
    public class Intern : Entity
    { 
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
        [MaxLength(50)]
        
        public string StudentCode { get; set; }
        [AllowNull]
        public School? School { get; set; }
        [MaxLength(50)]
        public string Department { get; set; }
        public DateTime StartDay { get; set; }
        [AllowNull]
        public DateTime? EndDay { get; set; }

        public Intern(int id)
        {
            UserId = id;
            StartDay = DateTime.Now;
        }

    }
}
