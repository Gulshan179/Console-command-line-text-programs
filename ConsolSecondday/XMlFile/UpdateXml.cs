    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

namespace ConsolSecondday.XMlFile
{


    class updatexml
    {
        static void Main5(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"E:\Visual tester\ConsolSecondday\ConsolSecondday\XMlFile\XMLFile1.xml");//path will come

            XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");
            foreach (XmlNode userNode in userNodes)
            {
                int age = int.Parse(userNode.Attributes["age"].Value); userNode.Attributes["age"].Value = (age + 1).ToString();
            }
            xmlDoc.Save("test_doc.xml"); Console.WriteLine("age is updated");

            XmlReader xmlReader = XmlReader.Create(@"E:\Visual tester\ConsolSecondday\ConsolSecondday\XMlFile\XMLFile1.xml");
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "user"))
                {
                    if (xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("age"));
                }
            }
            Console.ReadKey();
        }
    }
}

        /*  class UpdateXml
         {
             static void Main(string[] args)
             {
                 XmlDocument xmlDoc = new XmlDocument();
                 xmlDoc.Load("E:\\Visual tester\\ConsolSecondday\\ConsolSecondday\\XMl\\XMLFile1.xml");

                 XmlNodeList userNode = xmlDoc.SelectNodes("//users/user");
                 foreach (XmlNode node in userNode)
                 {
                     *//*int age = int.Parse(userNode.Attribute["age"].Value);
                     userNode.Attribute*//*
                 }
             }
         }*/
    
