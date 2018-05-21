using Abp.Application.Services;

namespace HM.Cloud
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class CloudAppServiceBase : ApplicationService
    {
        protected CloudAppServiceBase()
        {
            LocalizationSourceName = CloudConsts.LocalizationSourceName;
        }
    }
}