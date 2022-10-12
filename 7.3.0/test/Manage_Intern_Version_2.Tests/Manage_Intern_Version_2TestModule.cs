using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.TestBase;
using Manage_Intern_Version_2.EntityFrameworkCore;
using Castle.MicroKernel.Registration;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Manage_Intern_Version_2.Tests
{
    [DependsOn(
        typeof(Manage_Intern_Version_2ApplicationModule),
        typeof(Manage_Intern_Version_2EntityFrameworkCoreModule),
        typeof(AbpTestBaseModule)
        )]
    public class Manage_Intern_Version_2TestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
            SetupInMemoryDb();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Manage_Intern_Version_2TestModule).GetAssembly());
        }

        private void SetupInMemoryDb()
        {
            var services = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase();

            var serviceProvider = WindsorRegistrationHelper.CreateServiceProvider(
                IocManager.IocContainer,
                services
            );

            var builder = new DbContextOptionsBuilder<Manage_Intern_Version_2DbContext>();
            builder.UseInMemoryDatabase("Test").UseInternalServiceProvider(serviceProvider);

            IocManager.IocContainer.Register(
                Component
                    .For<DbContextOptions<Manage_Intern_Version_2DbContext>>()
                    .Instance(builder.Options)
                    .LifestyleSingleton()
            );
        }
    }
}