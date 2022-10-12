using Abp.AspNetCore.Mvc.Views;

namespace Manage_Intern_Version_2.Web.Views
{
    public abstract class Manage_Intern_Version_2RazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected Manage_Intern_Version_2RazorPage()
        {
            LocalizationSourceName = Manage_Intern_Version_2Consts.LocalizationSourceName;
        }
    }
}
