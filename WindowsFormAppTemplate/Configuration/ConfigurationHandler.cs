using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormAppTemplate.Configuration
{
    internal class ConfigurationHandler
    {
        public static string GetConfigurationValue(string key)
        {
            var value = ConfigurationManager.AppSettings[key];
            return value;
        }
    }
}
