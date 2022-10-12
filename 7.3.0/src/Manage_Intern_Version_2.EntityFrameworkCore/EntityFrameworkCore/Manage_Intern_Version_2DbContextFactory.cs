using Manage_Intern_Version_2.Configuration;
using Manage_Intern_Version_2.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Manage_Intern_Version_2.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class Manage_Intern_Version_2DbContextFactory : IDesignTimeDbContextFactory<Manage_Intern_Version_2DbContext>
    {
        public Manage_Intern_Version_2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Manage_Intern_Version_2DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(Manage_Intern_Version_2Consts.ConnectionStringName)
            );

            return new Manage_Intern_Version_2DbContext(builder.Options);
        }
    }
}