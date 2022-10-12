using Abp.Application.Services;

namespace Manage_Intern_Version_2
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class Manage_Intern_Version_2AppServiceBase : ApplicationService
    {
        protected Manage_Intern_Version_2AppServiceBase()
        {
            LocalizationSourceName = Manage_Intern_Version_2Consts.LocalizationSourceName;
        }
    }
}