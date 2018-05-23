using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HM.Cloud.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace HM.Cloud.Web.Startup
{
    [DependsOn(
        typeof(CloudApplicationModule), 
        typeof(CloudEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class CloudWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public CloudWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(CloudConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<CloudNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(CloudApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CloudWebModule).GetAssembly());
        }
    }
}