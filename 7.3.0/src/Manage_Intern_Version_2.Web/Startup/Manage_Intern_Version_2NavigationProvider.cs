using Abp.Application.Navigation;
using Abp.Localization;
using System.Drawing;
using System.Security.Policy;

namespace Manage_Intern_Version_2.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class Manage_Intern_Version_2NavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.ListUser,
                        L("ListUser"),
                        url: "Users",
                        icon: "fa fa-info"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, Manage_Intern_Version_2Consts.LocalizationSourceName);
        }
    }
}
