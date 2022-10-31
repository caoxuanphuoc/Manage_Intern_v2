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

namespace Manage_Intern_Version_2.Interns
{
    [Table("Intern")]
    public class Intern : Entity
    {
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [MaxLength(50)]
        public string StudentCode { get; set; }
        public School School { get; set; }
        [MaxLength(50)]
        public string Department { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }

        public Intern(int id)
        {
            UserId = id;
            StartDay = Clock.Now;
        }

    }
}
