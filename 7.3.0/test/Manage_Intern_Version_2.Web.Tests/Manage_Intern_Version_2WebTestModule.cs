using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Manage_Intern_Version_2.Web.Startup;
namespace Manage_Intern_Version_2.Web.Tests
{
    [DependsOn(
        typeof(Manage_Intern_Version_2WebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class Manage_Intern_Version_2WebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Manage_Intern_Version_2WebTestModule).GetAssembly());
        }
    }
}