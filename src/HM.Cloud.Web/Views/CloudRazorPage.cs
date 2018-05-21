using Abp.AspNetCore.Mvc.Views;

namespace HM.Cloud.Web.Views
{
    public abstract class CloudRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected CloudRazorPage()
        {
            LocalizationSourceName = CloudConsts.LocalizationSourceName;
        }
    }
}
