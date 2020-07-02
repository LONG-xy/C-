using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManagementApp
{
    public class WebSetting
    {
        private static string ApiUrl { get { return ConfigurationManager.AppSettings["SiteUrl"]; } }

        public static string GetUrl(string action)
        {
            return string.Format("{0}/{1}", ApiUrl, action);
        }
    }
}
