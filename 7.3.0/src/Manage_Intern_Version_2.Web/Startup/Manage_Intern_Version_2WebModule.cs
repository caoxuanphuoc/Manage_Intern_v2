using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Manage_Intern_Version_2.Configuration;
using Manage_Intern_Version_2.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Manage_Intern_Version_2.Web.Startup
{
    [DependsOn(
        typeof(Manage_Intern_Version_2ApplicationModule), 
        typeof(Manage_Intern_Version_2EntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class Manage_Intern_Version_2WebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Manage_Intern_Version_2WebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(Manage_Intern_Version_2Consts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<Manage_Intern_Version_2NavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(Manage_Intern_Version_2ApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Manage_Intern_Version_2WebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Manage_Intern_Version_2WebModule).Assembly);
        }
    }
}
