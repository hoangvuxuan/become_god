using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace become_god.all_class
{
    internal class Static_Class
    {
        public static string file_path = "data.xml";


        public static bool is_euqal_day(DateTime dt1, DateTime dt2)
        {
            if (dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day)
            {
                return true;
            }
            return false;
        }



        public static void create_file(string file_path)
        {
            if(!File.Exists(file_path))
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = doc.CreateElement("plan_list");

                doc.AppendChild(xmlDeclaration);
                doc.AppendChild(root);                
                doc.Save(file_path);

            }
        }



         
    }
}
