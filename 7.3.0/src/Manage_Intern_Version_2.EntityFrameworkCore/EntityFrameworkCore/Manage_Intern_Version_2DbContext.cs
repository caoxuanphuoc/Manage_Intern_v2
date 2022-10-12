using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Manage_Intern_Version_2.EntityFrameworkCore
{
    public class Manage_Intern_Version_2DbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public Manage_Intern_Version_2DbContext(DbContextOptions<Manage_Intern_Version_2DbContext> options) 
            : base(options)
        {

        }
    }
}
