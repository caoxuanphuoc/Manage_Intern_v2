using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Manage_Intern_Version_2
{
    [DependsOn(
        typeof(Manage_Intern_Version_2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Manage_Intern_Version_2ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Manage_Intern_Version_2ApplicationModule).GetAssembly());
        }
    }
}