using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace HM.Cloud.EntityFrameworkCore
{
    [DependsOn(
        typeof(CloudCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class CloudEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CloudEntityFrameworkCoreModule).GetAssembly());
        }
    }
}