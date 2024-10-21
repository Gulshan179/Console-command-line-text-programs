using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsolSecondday.XMlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XmlUsingPlainCode());
        }
        static XDocument XmlUsingPlainCode()
        {
            XDocument document = new XDocument
            (
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("XML from plain code"),
            new XElement("Courses")
            );
            return document;
        }
    }
}
