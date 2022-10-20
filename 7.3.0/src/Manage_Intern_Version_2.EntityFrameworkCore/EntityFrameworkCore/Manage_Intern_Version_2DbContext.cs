using Abp.EntityFrameworkCore;
using Manage_Intern_Version_2.Interns;
using Manage_Intern_Version_2.Mentors;
using Manage_Intern_Version_2.Users;
using Microsoft.EntityFrameworkCore;

namespace Manage_Intern_Version_2.EntityFrameworkCore
{
    public class Manage_Intern_Version_2DbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<User> Users { get; set; }
        public DbSet<Intern> Interns { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public Manage_Intern_Version_2DbContext(DbContextOptions<Manage_Intern_Version_2DbContext> options) 
            : base(options)
        {

        }
    }
}
