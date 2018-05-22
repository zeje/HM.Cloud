using HM.Cloud.Web.Startup;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HM.Cloud.Web.Utils
{

    public static class SiteHelper
    {
        public static FileVersionInfo GetFileVersionInfo()
        {
            Assembly assembly = typeof(Program).GetTypeInfo().Assembly;
            AssemblyName assemblyName = assembly.GetName();
            return FileVersionInfo.GetVersionInfo(assembly.Location);
        }
    }
}
