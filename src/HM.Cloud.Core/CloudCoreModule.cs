using Abp.Modules;
using Abp.Reflection.Extensions;
using HM.Cloud.Localization;

namespace HM.Cloud
{
    public class CloudCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            CloudLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CloudCoreModule).GetAssembly());
        }
    }
}