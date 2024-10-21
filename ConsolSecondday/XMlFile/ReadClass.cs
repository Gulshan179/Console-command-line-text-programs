    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    namespace ConsolSecondday.XMlFile
    {
        class ReadClass
        {
            static void Main(string[] args)
            {
                XmlReader xlReader = XmlReader.Create("userNodesE:\\Visual tester\\ConsolSecondday\\ConsolSecondday\\XMl\\XMLFile1.xml");
                while (xlReader.Read()) 
                {
                    if((xlReader.NodeType== XmlNodeType.Element) && (xlReader.Name=="user"))
                    {

                        if(xlReader.HasAttributes)
                        {
                            Console.WriteLine(xlReader.GetAttribute("age"));
                        }
                    }
                }
                Console.ReadLine();
            }
        }
    }
