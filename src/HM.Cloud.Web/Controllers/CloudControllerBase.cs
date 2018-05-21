using Abp.AspNetCore.Mvc.Controllers;

namespace HM.Cloud.Web.Controllers
{
    public abstract class CloudControllerBase: AbpController
    {
        protected CloudControllerBase()
        {
            LocalizationSourceName = CloudConsts.LocalizationSourceName;
        }
    }
}