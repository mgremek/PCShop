using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPFSklep.Model
{
    class XmlParsing
    {
        XmlDocument xd;
        List<string> lista;
        String name;
        public XmlParsing(string text)
        {
            xd = new XmlDocument();
            xd.LoadXml(text);
            lista = new List<string>();
        }
        public List<string> ParseXml()
        {
            foreach (XmlNode item in xd)
            {
                foreach (XmlNode i in item)
                {
                    name = i.Name + ": " + i.InnerText;
                    lista.Add(name.Replace('_',' '));                 
                }                            
            }
            return lista;
        }
    }
}
