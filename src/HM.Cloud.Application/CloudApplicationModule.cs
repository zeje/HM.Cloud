using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace HM.Cloud
{
    [DependsOn(
        typeof(CloudCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CloudApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CloudApplicationModule).GetAssembly());
        }
    }
}