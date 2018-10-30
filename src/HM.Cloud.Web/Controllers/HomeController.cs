using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HM.Cloud.Web.Controllers
{
    public class HomeController : CloudControllerBase
    {
        public ActionResult Index()
        {
            var fvi = Utils.SiteHelper.GetFileVersionInfo();
            ViewBag.UserName = "zezhi@163.com";
            ViewBag.PlatformName = fvi.ProductName;
            ViewBag.PlatformVersion = fvi.FileVersion;
            ViewBag.PlatformCopyright = fvi.LegalCopyright;
            return View();
        }

        public ActionResult Portal()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}