using System.Collections.Generic;
using Abp.Localization;
using Microsoft.AspNetCore.Http;

namespace Manage_Intern_Version_2.Web.Views.Shared.Components.LanguageSelection
{
    public class LanguageSelectionViewModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public IReadOnlyList<LanguageInfo> Languages { get; set; }

        public PathString CurrentUrl { get; set; }
    }
}