using Microsoft.EntityFrameworkCore;

namespace Manage_Intern_Version_2.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<Manage_Intern_Version_2DbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for Manage_Intern_Version_2DbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
