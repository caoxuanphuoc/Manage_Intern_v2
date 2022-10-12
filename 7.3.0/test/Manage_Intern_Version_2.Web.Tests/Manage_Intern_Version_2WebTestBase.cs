using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Abp.AspNetCore.TestBase;
using Manage_Intern_Version_2.EntityFrameworkCore;
using Manage_Intern_Version_2.Tests.TestDatas;
using Manage_Intern_Version_2.Web.Controllers;
using Manage_Intern_Version_2.Web.Startup;
using Manage_Intern_Version_2.Web.Tests.Controllers;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Shouldly;

namespace Manage_Intern_Version_2.Web.Tests
{
    public abstract class Manage_Intern_Version_2WebTestBase : AbpAspNetCoreIntegratedTestBase<Startup>
    {
        protected static readonly Lazy<string> ContentRootFolder;

        static Manage_Intern_Version_2WebTestBase()
        {
            ContentRootFolder = new Lazy<string>(WebContentDirectoryFinder.CalculateContentRootFolder, true);
        }

        protected Manage_Intern_Version_2WebTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            return base
                .CreateWebHostBuilder()
                .UseContentRoot(ContentRootFolder.Value)
                .UseSetting(WebHostDefaults.ApplicationKey, typeof(Manage_Intern_Version_2WebModule).Assembly.FullName);
        }

        #region Get response

        protected async Task<T> GetResponseAsObjectAsync<T>(string url,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            var strResponse = await GetResponseAsStringAsync(url, expectedStatusCode);
            return JsonConvert.DeserializeObject<T>(strResponse, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

        protected async Task<string> GetResponseAsStringAsync(string url,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            var response = await GetResponseAsync(url, expectedStatusCode);
            return await response.Content.ReadAsStringAsync();
        }

        protected async Task<HttpResponseMessage> GetResponseAsync(string url,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            var response = await Client.GetAsync(url);
            response.StatusCode.ShouldBe(expectedStatusCode);
            return response;
        }

        #endregion

        #region UsingDbContext

        protected void UsingDbContext(Action<Manage_Intern_Version_2DbContext> action)
        {
            using (var context = IocManager.Resolve<Manage_Intern_Version_2DbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected T UsingDbContext<T>(Func<Manage_Intern_Version_2DbContext, T> func)
        {
            T result;

            using (var context = IocManager.Resolve<Manage_Intern_Version_2DbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected async Task UsingDbContextAsync(Func<Manage_Intern_Version_2DbContext, Task> action)
        {
            using (var context = IocManager.Resolve<Manage_Intern_Version_2DbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected async Task<T> UsingDbContextAsync<T>(Func<Manage_Intern_Version_2DbContext, Task<T>> func)
        {
            T result;

            using (var context = IocManager.Resolve<Manage_Intern_Version_2DbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }

        #endregion

        #region ParseHtml

        protected IHtmlDocument ParseHtml(string htmlString)
        {
            return new HtmlParser().ParseDocument(htmlString);
        }

        #endregion
    }
}