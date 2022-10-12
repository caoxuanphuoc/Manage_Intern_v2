using Abp.Modules;
using Abp.Reflection.Extensions;
using Manage_Intern_Version_2.Localization;

namespace Manage_Intern_Version_2
{
    public class Manage_Intern_Version_2CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            Manage_Intern_Version_2LocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = Manage_Intern_Version_2Consts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Manage_Intern_Version_2CoreModule).GetAssembly());
        }
    }
}