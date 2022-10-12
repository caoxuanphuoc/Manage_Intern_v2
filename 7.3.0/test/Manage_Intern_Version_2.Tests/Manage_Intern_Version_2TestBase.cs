using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Manage_Intern_Version_2.EntityFrameworkCore;
using Manage_Intern_Version_2.Tests.TestDatas;

namespace Manage_Intern_Version_2.Tests
{
    public class Manage_Intern_Version_2TestBase : AbpIntegratedTestBase<Manage_Intern_Version_2TestModule>
    {
        public Manage_Intern_Version_2TestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<Manage_Intern_Version_2DbContext> action)
        {
            using (var context = LocalIocManager.Resolve<Manage_Intern_Version_2DbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<Manage_Intern_Version_2DbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<Manage_Intern_Version_2DbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<Manage_Intern_Version_2DbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<Manage_Intern_Version_2DbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<Manage_Intern_Version_2DbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<Manage_Intern_Version_2DbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
