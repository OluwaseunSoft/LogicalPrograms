using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LogicalPrograms
{
    public static class ConfigurationUtility
    {
        public static string GetAppSettingValue(string appSettingsKey)
        {
            return ConfigurationManager.AppSettings[appSettingsKey];
        }
        public static string GetConnectionStringValue(string connectionStringName)
        {
            return ConfigurationManager.ConnectionStrings[connectionStringName].ToString();
        }
    }
}
