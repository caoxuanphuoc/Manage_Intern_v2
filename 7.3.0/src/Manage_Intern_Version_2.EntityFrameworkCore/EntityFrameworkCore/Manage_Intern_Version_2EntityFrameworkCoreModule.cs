using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Manage_Intern_Version_2.EntityFrameworkCore
{
    [DependsOn(
        typeof(Manage_Intern_Version_2CoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class Manage_Intern_Version_2EntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Manage_Intern_Version_2EntityFrameworkCoreModule).GetAssembly());
        }
    }
}