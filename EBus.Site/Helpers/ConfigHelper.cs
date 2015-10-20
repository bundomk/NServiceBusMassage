using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EBus.Site.Helpers
{
    public static class ConfigHelper
    {
        public static string GetEndpointFromApp(string key)
        {
            if (ConfigurationManager.AppSettings[key] != null)
                return ConfigurationManager.AppSettings[key];
            else
                return null;
        }
    }
}