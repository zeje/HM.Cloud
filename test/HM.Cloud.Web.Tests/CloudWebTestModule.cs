using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HM.Cloud.Web.Startup;
namespace HM.Cloud.Web.Tests
{
    [DependsOn(
        typeof(CloudWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class CloudWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CloudWebTestModule).GetAssembly());
        }
    }
}