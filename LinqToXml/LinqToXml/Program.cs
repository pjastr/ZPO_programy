using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    //kod ze strony https://www.tutorialspoint.com/linq/linq_xml.htm

    class Program
    {
        static void Main(string[] args)
        {
            string myXML = @"<Departments>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Add new Element
            //xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            //Add new Element at First
            //xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            //Remove Sales Department
            //xdoc.Descendants().Where(s => s.Value == "Sales").Remove();

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
