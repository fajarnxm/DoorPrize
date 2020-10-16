using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml.Linq;

namespace DoorPrize.framework
{
    public static class ConfigManager
    {
        private static string str = "";
        private static string file = "Config.xml";
        //private static string fName = HttpContext.Current.Server.MapPath(".") + @"\xml\" + file;
        private static string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string fName = System.IO.Path.GetDirectoryName(Exepath) + "\\" + "xml" + "\\" + file;

        public static string GetSetting(string tag)
        {
            fName = fName.Replace("\\PopUp", "");
            fName = fName.Replace("\\Report", "");
            XDocument xmldoc = XDocument.Load(fName);
            XElement xElement = xmldoc.Elements("settings").Descendants(tag).FirstOrDefault();
            str = xElement.Value.ToString();
            return str;
        }

        public static void SetSetting(string tag, string val)
        {
            fName = fName.Replace("\\PopUp", "");
            fName = fName.Replace("\\Report", "");
            XDocument xmldoc = XDocument.Load(fName);
            xmldoc.Elements("settings").Descendants(tag).FirstOrDefault().SetValue(val);
            xmldoc.Save(fName);
        }
    }
}
