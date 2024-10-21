using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsolSecondday.XMlFile
{
     class CreateXml
    {
        static void Main(string[] args)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNode rootNode = xmldoc.CreateElement("Users");
            xmldoc.AppendChild(rootNode);
            XmlNode UserNode = xmldoc.CreateElement("user");
            XmlAttribute attibute = xmldoc.CreateAttribute("age");
            attibute.Value = "50";
            UserNode.Attributes.Append(attibute);
            UserNode.InnerText = "Gulshan Chauhan";

            rootNode.AppendChild(UserNode);
            xmldoc.Save("E:\\Visual tester\\ConsolSecondday\\ConsolSecondday\\XMl\\XMLFile1.xml");
            Console.WriteLine("Test_doct file is created");
            Console.ReadLine();

        }
    }
}
