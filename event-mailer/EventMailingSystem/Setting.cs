using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMailingSystem
{
    public class Setting
    {
        string _assemblyLocation;
        Configuration _configuration;

        public Setting(string assemblyLocation)
        {
            _assemblyLocation = assemblyLocation;
        }

        
        Configuration Configuration
        {
            get
            {
                if (_configuration == null)
                {
                    try
                    {
                        _configuration = ConfigurationManager.OpenExeConfiguration(_assemblyLocation);
                    }
                    catch
                    {
                    }
                }
                return _configuration;
            }
        }
        
        public string AppSetting(string key)
        {
            string result = string.Empty;
            if (Configuration != null)
            {
                KeyValueConfigurationElement keyValueConfigurationElement = Configuration.AppSettings.Settings[key];
                if (keyValueConfigurationElement != null)
                {
                    string value = keyValueConfigurationElement.Value;
                    if (!string.IsNullOrEmpty(value)) result = value;
                }
            }
            return result;
        }        
    }
}
